using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;


namespace MinVR {

public class XMLUtils {
	
	static public int NumSubstringOccurances(string str, string substr) {
		int n = 0;
		int start = str.IndexOf(substr);
		while (start != -1) {
			n++;
			str = str.Substring(start+1);
			start = str.IndexOf(substr);
			n++;
		}
		return n;
	}
	
	
	static public int FindNth(string str, string substr, int n) {
		int nthIndex = 0;
		for (int i=0;i<n;i++) {
			int index = str.IndexOf(substr);
			if (index == -1)
				return -1;
			str = str.Substring(index+1);
			if (i == 0)
				nthIndex = index;
			else
				nthIndex += index+1;
		}
		return nthIndex;
	}
	
	static public string GetNextXMLFieldName(string input) {
		int start = input.IndexOf("<");
		int len = input.Substring(start + 1).IndexOfAny(new char[] {'>', ' '});
			if ((start == -1) || (len == -1)) {
			return string.Empty;
		}
		return input.Substring(start+1, len);
	}

	static public bool GetXMLField(string input, string fieldName, ref Dictionary<string,string> propertiesAndValues, ref string fieldData, ref string leftoverInput) {
		// Clear out the table of values
		propertiesAndValues.Clear();
		
		// Look for the beginning of the expected field
		int startfield = input.IndexOf("<" + fieldName);
		if (startfield == -1) {
			leftoverInput = input;
			return false;
		}
		
		// Get the substring that contains all the attributes of the field
		string propplus = input.Substring(startfield + fieldName.Length + 1);
		int endofnameandproperties = propplus.IndexOf(">");
		string properties = propplus.Substring(0,endofnameandproperties);
		
		
		while ((properties.Length > 0) && (properties.IndexOf("=") != -1)) {
			properties = properties.Trim();
			int equals = properties.IndexOf("=");
			string name = properties.Substring(0,equals);
			bool quoted = false;
			if (properties[equals+1] == '"') {
				quoted = true;
				equals++;
			}
			string valplus = properties.Substring(equals+1);
			int end = 0;
			if (quoted)
				end = valplus.IndexOf("\"");
			else
				end = valplus.IndexOf(" ");
			string value = valplus.Substring(0,end);
			propertiesAndValues.Add(name, value);
			properties = valplus.Substring(end+1);
		}
		
		// If there is no data, then some XML writers will end the field
		// with a /> rather than the conventional way
		if ((endofnameandproperties-1 >= 0) && (propplus[endofnameandproperties-1] == '/')) {
			leftoverInput = propplus.Substring(endofnameandproperties + 1);
		}
		else {
			
			// Get all the xml text after the end of the field begin carrot
			// symbols everything from here to the matching </myXmlField> is
			// stored in the field data.  This is a little tricky because there
			// may be a subfield with the same fieldName *inside* the field
			// data, so we need to make sure we have the right number of xml
			// field start tokens and field end tokens.
			string dataplus = propplus.Substring(endofnameandproperties + 1);
			
			int numstart = 1;
			int numend = 0;
			int endofdata = 0;
			while (numend != numstart) {
				endofdata = FindNth(dataplus, "</" + fieldName + ">", numend+1);
				if (endofdata == -1) {
					Debug.Log("getXMLField error: Can't find the " + (numend+1) + "-th occurance of </" + fieldName + "> in " + dataplus);
					return false;
				}
				numend++;
				fieldData = dataplus.Substring(0, endofdata);
				numstart = NumSubstringOccurances(fieldData, "<" + fieldName + ">") + NumSubstringOccurances(fieldData, "<" + fieldName + " ") + 1;
			}
			
			leftoverInput = dataplus.Substring(endofdata+1);
		}
		
		return true;
	}

	static public string WriteXMLField(string fieldName, Dictionary<string, string> propertiesAndValues, string fieldData) {
		string s = "<" + fieldName;
		foreach(var item in propertiesAndValues) {
			s = s + " " + item.Key + "=\"" + item.Value + "\"";
		}
		s = s + ">" + fieldData + "</" + fieldName + ">\n";

		return s;
	}
}

} // namespace MinVR
