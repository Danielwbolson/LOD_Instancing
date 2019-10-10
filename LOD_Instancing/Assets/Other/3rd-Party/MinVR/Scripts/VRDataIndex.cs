using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;


namespace MinVR {

/** The C# implementation of VRDataIndex.  In the C++ implementation, VRDataIndex is
 * limited to storing only the VRCoreTypes defined above.  In C#, it can technically
 * store objects of any type, since it is essentially a wrapper around a Hashtable.  
 * However, in practice, we'll limit ourselves to storing the VRCoreTypes in order
 * to stay compatible with the way that the MinVR NetClient and NetServer exchange
 * data.
 * 
 * This C# implmentation does not yet fully support namespaces - you can strore data 
 * using a key with a "/" in it (e.g., name = "Time0/Position"), but we don't yet 
 * have a nice way to ask the index for all the keys within the "Time0" namespace.
 * More importantly, the constructor does not yet understand how to create 
*/
public class VRDataIndex {

	private Hashtable _hash;


	// Declare a DataHash property of type Hashtable
	public Hashtable DataHash {
		get {
			return _hash;
		}
		set {
			_hash = value;
		}
	}

	// This function mirrors the C++ implementaiton of VRDataIndex.
	// Data are stored in the index in (name, value) pairs.
	public void AddData(string name, object value) {
		_hash.Add(name, value);
	}

	// This function returns the value stored under 'name'.
	// Programmers must cast this to the correct type.
	public object GetValue(string name) {
		return _hash[name];
	}

	public int GetValueAsInt(string name) {
		return (int)_hash[name];
	}

	public double GetValueAsDouble(string name) {
		return (double)_hash[name];
	}

	public string GetValueAsString(string name) {
		return (string)_hash[name];
	}
	
	public int[] GetValueAsIntArray(string name) {
		return (int[])_hash[name];
	}

	public double[] GetValueAsDoubleArray(string name) {
		return (double[])_hash[name];
	}

	public string[] GetValueAsStringArray(string name) {
		return (string[])_hash[name];
	}


	public string DataToXML(string name) {
		Dictionary<string, string> props = new Dictionary<string, string>();
		string fieldData = string.Empty;
		char separatingChar = '@';

		Type valueType = _hash[name].GetType();

		if (valueType.IsArray) { // array type
			// properties and values
			// returns if it is an unkown type.
			if (valueType == typeof(int[])) {
				props.Add("type", "intarray");
			} else if (valueType == typeof(double[])) {
				props.Add("type", "doublearray");
			} else if (valueType == typeof(string[])) {
				props.Add("type", "stringarray");
			} else { // returns if it is an unkown type.
				Debug.LogWarning("Unknown type: " + valueType.ToString());
				return "";
			}

			// field data
			IEnumerable enumerable = _hash[name] as IEnumerable;
			if (enumerable != null) {
				bool hasRan = false;
				foreach(object element in enumerable) {
					fieldData += element.ToString() + separatingChar;
					hasRan = true;
				}
				if (hasRan) { // if the for-loop has ran at least once, trim the last char.
					fieldData.TrimEnd(separatingChar); 
				}
			} else {
				Debug.LogWarning("Not enumerable value: " + _hash[name].ToString());
				return "";
			}
		} else { // non-array type
			// properties and values, field data
			// returns if it is an unkown type.
			if (valueType == typeof(int)) {
				props.Add("type", "int");
				fieldData = GetValueAsInt(name).ToString();
			} else if (valueType == typeof(double)) {
				props.Add("type", "double");
				fieldData = GetValueAsDouble(name).ToString();
			} else if (valueType == typeof(string)) {
				props.Add("type", "string");
				fieldData = GetValueAsString(name);
			} else { // returns if it is an unkown type.
				Debug.LogWarning("Unknown type: " + valueType.ToString());
				return "";
			}
		}

		return XMLUtils.WriteXMLField(name, props, fieldData);
	}

	public string ToXML() {
		string s = "<VRDataIndex>";
		foreach (DictionaryEntry entry in _hash) {
				s += DataToXML(entry.Key.ToString());
		}
		s += "</VRDataIndex>";
		return s;
	}


	// This function returns the names (keys) for all of the values stored in the hashtable.
	public ICollection GetNames() {
		return _hash.Keys;
	}

	// Creates a VRDataIndex from an XML-formatted description.  xmlDescription is modified as part of the constructor.  The
	// first VRDataIndex described <VRDataIndex>...</VRDataIndex> is popped off the string and xmlDescription is set to whatever
	// remains in the string.
	public VRDataIndex(ref string xmlDescription) {
		_hash = new Hashtable();

		Dictionary<string, string> props = new Dictionary<string, string>();
		string xmlData = string.Empty;
		string xmlRemaining = string.Empty;
		bool success = XMLUtils.GetXMLField(xmlDescription, "VRDataIndex", ref props, ref xmlData, ref xmlRemaining);
		if (!success) {
			Debug.Log("Error decoding VRDataIndex");
			return;
		}

		string nextField = XMLUtils.GetNextXMLFieldName(xmlData);
		while (nextField != string.Empty) {
			string datumValue = string.Empty;
			string xmlDataRemaining = string.Empty;
			success = XMLUtils.GetXMLField(xmlData, nextField, ref props, ref datumValue, ref xmlDataRemaining);
			if (!success) {
				Debug.Log("Error decoding VRDatum named " + nextField);
				return;
			}

			char[] separatingChars = { '@' };
			if (props["type"] == "int") {
				//Debug.Log ("Got int: " + nextField + "=" + datumValue);
				_hash.Add(nextField, Convert.ToInt32(datumValue));
			}
			else if (props["type"] == "double") {
				//Debug.Log ("Got double: " + nextField + "=" + datumValue);
				_hash.Add(nextField, Convert.ToDouble(datumValue));
			}
			else if (props["type"] == "string") {
				//Debug.Log ("Got string: " + nextField + "=" + datumValue);
				_hash.Add(nextField, datumValue);
			}
			else if (props["type"] == "intarray") {
				//Debug.Log ("Got intarray: " + nextField + "=" + datumValue);
				string[] elements = datumValue.Split(separatingChars, System.StringSplitOptions.RemoveEmptyEntries);
				int[] intarray = new int[elements.Length];
				for (int i=0; i<elements.Length; i++) {
					intarray[i] = Convert.ToInt32(elements[i]);
				}
				_hash.Add(nextField, intarray);
			}
			else if (props["type"] == "doublearray") {
				//Debug.Log ("Got doublearray: " + nextField + "=" + datumValue);
				string[] elements = datumValue.Split(separatingChars, System.StringSplitOptions.RemoveEmptyEntries);
				double[] doublearray = new double[elements.Length];
				for (int i=0; i<elements.Length; i++) {
					doublearray[i] = Convert.ToDouble(elements[i]);
				}
				_hash.Add(nextField, doublearray);
			}
			else if (props["type"] == "stringarray") {
				//Debug.Log ("Got stringarray: " + nextField + "=" + datumValue);
				string[] elements = datumValue.Split(separatingChars, System.StringSplitOptions.RemoveEmptyEntries);
				string[] strarray = new string[elements.Length];
				for (int i=0; i<elements.Length; i++) {
					strarray[i] = elements[i];
				}
				_hash.Add(nextField, strarray);
			}
			else {
				Debug.Log("Unknown VRDatum type: " + props["type"]);
			}

			xmlData = xmlDataRemaining;
			nextField = XMLUtils.GetNextXMLFieldName(xmlData);
		}

		xmlDescription = xmlRemaining;
	}

	// Generic constructor, creates an empty VRDataIndex
	public VRDataIndex() {
		_hash = new Hashtable();
	}

}

} // namespace MinVR
