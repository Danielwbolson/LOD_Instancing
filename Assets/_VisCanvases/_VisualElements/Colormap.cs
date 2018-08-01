using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

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

            if (extention.ToUpper() == ".PNG") {
                Colormap result = null;
                Texture2D loadedImage = new Texture2D(1, 1);
                loadedImage.LoadImage(File.ReadAllBytes(filePath));
                result = CreateInstance<Colormap>().Init(loadedImage);
                return result;
            }

            // Read XML file and produce a Texture2D
            if (extention.ToUpper() == ".XML") {
                List<float> dataArray = new List<float>();
                StreamReader inStream = new StreamReader(filePath);

                while (!inStream.EndOfStream) {
                    string inLine = inStream.ReadLine();
                    
                    if (inLine.Contains("Point")) {
                        string[] split = inLine.Split('"');
                        float x = float.Parse(split[1]);
                        float r = float.Parse(split[5]);
                        float g = float.Parse(split[7]);
                        float b = float.Parse(split[9]);

                        dataArray.Add(x);
                        dataArray.Add(r);
                        dataArray.Add(g);
                        dataArray.Add(b);
                    }
                }
                inStream.Close();

                Colormap result = null;
                Texture2D image = new Texture2D(1, 1);
                image = CreateTexture2DFromList(dataArray);
                result = CreateInstance<Colormap>().Init(image);
                return result;
            }

            // Read JSON file and produce a Texture2D
            if (extention.ToUpper() == ".JSON") {
                bool atData = false;
                List<float> dataArray = new List<float>();
                StreamReader inStream = new StreamReader(filePath);

                while (!inStream.EndOfStream) {
                    string inLine = inStream.ReadLine();

                    if (atData) {
                        if (inLine.Contains("]")) {
                            break;
                        }

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

                    inLine.Trim();
                    string[] split = inLine.Split(' ', '\t');

                    for (int i = 0; i < split.Length; i++) {
                        if (!split[i].Contains(" ") && !split[i].Equals("")) {
                            float v = float.Parse(split[i]);
                            dataArray.Add(v);
                        }
                    }
                }
                inStream.Close();

                Colormap result = null;
                Texture2D image = new Texture2D(1, 1);
                image = CreateTexture2DFromList(dataArray, true);
                result = CreateInstance<Colormap>().Init(image);
                return result;
            }
            return null;
        }

        public static Texture2D CreateTexture2DFromList(List<float> dataList, bool HSV = false) {
            //Texture2D newImage = new Texture2D(1, 1);
            return null;
        }
    }
}
