using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Xml;

namespace SculptingVis {
    public class Colormap : VisualElement {
        [SerializeField]
        Texture2D _texture;

        public Texture2D GetTexture() {
            return _texture;
        }
        protected Colormap Init(Texture2D texture) {
            _texture = texture;
            return this;
        }
        public new static VisualElement LoadFile(string filePath) {

            string extention = Path.GetExtension(filePath);

            // Read PNG file and produce a Texture2D
            if (extention.ToUpper() == ".PNG") {
                // Create and return the image
                Colormap result = null;
                Texture2D loadedImage = new Texture2D(1, 1);
                loadedImage.LoadImage(File.ReadAllBytes(filePath));
                result = CreateInstance<Colormap>().Init(loadedImage);
                return result;
            }

            // Read XML file and produce a Texture2D
            if (extention.ToUpper() == ".XML") {

                XmlDocument doc = new XmlDocument();
                doc.Load(filePath);

                XmlNode colormapNode = doc.DocumentElement.SelectSingleNode("/ColorMaps/ColorMap");
                string name = colormapNode.Attributes.GetNamedItem("name").Value;

                List<float> dataArray = new List<float>();

               foreach(XmlNode pointNode in colormapNode.SelectNodes("Point")){
                    float x = float.Parse(pointNode.Attributes.GetNamedItem("x").Value);
                    float r = float.Parse(pointNode.Attributes.GetNamedItem("r").Value);
                    float g = float.Parse(pointNode.Attributes.GetNamedItem("g").Value);
                    float b = float.Parse(pointNode.Attributes.GetNamedItem("b").Value);

                    // Add our values to our list
                    dataArray.Add(x);
                    dataArray.Add(r);
                    dataArray.Add(g);
                    dataArray.Add(b);

                }  

                // Create and return the image
                Colormap result = null;
                Texture2D image = new Texture2D(1, 1);
                image = CreateTexture2DFromList(dataArray);
                result = CreateInstance<Colormap>().Init(image);
                result.SetName(name);
                return result;
            }

            // Read JSON file and produce a Texture2D
            if (extention.ToUpper() == ".JSON") {
                bool atData = false;
                List<float> dataArray = new List<float>();
                StreamReader inStream = new StreamReader(filePath);

                while (!inStream.EndOfStream) {
                    string inLine = inStream.ReadLine();

                    // If we are within the data points
                    if (atData) {
                        if (inLine.Contains("]")) {
                            break;
                        }

                        // Trim and split by commas to get the data
                        inLine.Trim();
                        string[] noComma = inLine.Split(","[0]);
                        float x = float.Parse(noComma[0]);
                        dataArray.Add(x);
                    }

                    if (inLine.Contains("RGBPoints")) {
                        atData = true;
                    }
                }
                inStream.Close();

                // Create and return the image
                Colormap result = null;
                Texture2D image = new Texture2D(1, 1);
                image = CreateTexture2DFromList(dataArray);
                result = CreateInstance<Colormap>().Init(image);
                return result;
            }

            // Read TXT file and produce a Texture2D
            if (extention.ToUpper() == ".TXT") {
                List<float> dataArray = new List<float>();
                StreamReader inStream = new StreamReader(filePath);

                while (!inStream.EndOfStream) {
                    string inLine = inStream.ReadLine();

                    // Trim and split by tabs and spaces
                    inLine.Trim();
                    string[] split = inLine.Split(' ', '\t');

                    // Make sure the chunks are not spaces and not empty
                    for (int i = 0; i < split.Length; i++) {
                        if (!split[i].Contains(" ") && !split[i].Equals("")) {
                            float v = float.Parse(split[i]);
                            dataArray.Add(v);
                        }
                    }
                }
                inStream.Close();

                // Create and return the image
                Colormap result = null;
                Texture2D image = new Texture2D(1, 1);
                image = CreateTexture2DFromList(dataArray, true);
                result = CreateInstance<Colormap>().Init(image);
                return result;
            }
            return null;
        }

        // Given a list of data, create a texture
        public static Texture2D CreateTexture2DFromList(List<float> dataList, bool HSV = false) {
            List<float> increments = new List<float>();
            List<Color> pixels = new List<Color>();
            int imageWidth;

            float minIncrement = Mathf.Infinity;

            // Create an array of Colors
            for (int i = 0; i < dataList.Count; i += 4) {
                Color c;

                float x = dataList[i];
                float r = dataList[i + 1];
                float g = dataList[i + 2];
                float b = dataList[i + 3];

                if (HSV) {
                    if (r > 1 || g > 1 || b > 1) {
                        r /= 360.0f;
                        g /= 100.0f;
                        b /= 100.0f;
                    }
                    c = Color.HSVToRGB(r, g, b);
                    c.a = 1;
                } else {
                    c = new Color(r, g, b, 1.0f);
                }

                // Get the minimum increment so that we can scale by a certain value and 
                // generate a decent picture
                if (i > 0) {
                    float inc = x - dataList[i - 4];
                    if (inc < minIncrement && inc > 0) {
                        minIncrement = inc;
                    }
                }
                increments.Add(x);
                pixels.Add(c);
            }

            // Create our texture and get its width
            imageWidth = (int)(4 * (1 / minIncrement));
            Texture2D image = new Texture2D(imageWidth, 1);

            // Set our new pixels, generated from our data and Lerp
            List<Color> newPixels = new List<Color>();
            int j = 0;
            for (int i = 1; i < increments.Count; i++) {
                int leftStep = (int)(increments[i - 1] * imageWidth);
                int rightStep = (int)(increments[i] * imageWidth);
                while (j < rightStep) {
                    Color l = pixels[i - 1];
                    Color r = pixels[i];

                    Color p = Color.Lerp(l, r, (float)(j - leftStep) / (rightStep - leftStep));
                    newPixels.Add(p);
                    j++;
                }
            }
            image.SetPixels(newPixels.ToArray());
            image.Apply();
            return image;
        }
    }
}
