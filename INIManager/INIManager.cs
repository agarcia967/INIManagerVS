using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace INIManager
{
    class INIManager
    {
        public static bool DEBUG = false;
        private static bool INDICES = false;

        private int totalKeys = 0;
        private int keysRead = 0;

        private Dictionary<string, Dictionary<string, string>> items;

        /**
         * Creates a new INI file manager. Initializes the headers.
         */
        public INIManager()
        {
            this.items = new Dictionary<string, Dictionary<string, string>>();
        }

        /**
         * Creates a new INI file manager. Initializes with a list of headers.
         * @param headers	the list of headers to add
         */
        public INIManager(string[] headers)
        {
            this.items = new Dictionary<string, Dictionary<string, string>>();
            if (headers == null) return;
            foreach (string h in headers)
            {
                this.items.Add(h.ToUpper(), new Dictionary<string, string>());
            }
        }

        /**
         * Creates a new INI file manager. Initializes one header and its keys.
         * @param header	the header under which to add the keys
         * @param keys		the list of keys to add
         */
        public INIManager(string header, string[] keys)
        {
            this.items = new Dictionary<string, Dictionary<string, string>>();
            if (header == null) return;
            if (keys == null) return;
            foreach (string k in keys)
            {
                this.addKey(header.ToUpper(), k);
            }
        }

        /**
         * Creates a new header under which to create keys.
         *
         * @param header	Name of the header.
         * @return			Returns false if the header already exists.
         */
        public bool addHeader(string header)
        {
            if (DEBUG) Console.WriteLine("addHeader('" + header + "') called");
            header = header.ToUpper();
            if (header.Equals("")) header = "NOHEADER";
            if (this.items.Keys.Contains(header))
            {
                if (DEBUG) Console.WriteLine("WARNING: Header '" + header +
                     "' already exists. Header NOT added!");
                return false;
            }
            //initialize the new header for adding keys to later
            this.items.Add(header, new Dictionary<string, string>());
            return true;
        }

        /**
         * Creates a new key under the header. If the header does not exist,
         * it will create one.
         *
         * @param header	Name of the header under which this key will be found.
         * @param key		The key to add that will be listed under the above header.
         * @return			Returns false if the key already exists under this header.
         */
        public bool addKey(string header, string key)
        {
            if (DEBUG) Console.WriteLine("addKey('" + header + "', '" + key + "') called");
            header = header.ToUpper();
            //Check if the key already exists
            if (!this.items.Keys.Contains(header)) this.addHeader(header);

            //We may assume from the code above that the header is not null
            // (If it was, it would have been created)
            if (this.items[header].Keys.Contains(key))
            {
                if (DEBUG) Console.WriteLine(" WARNING: Key '" + key +
                     "' already exists. Key NOT added!");
                return false;
            }
            else
            {
                this.items[header].Add(key, "");
                this.totalKeys++;
            }

            return true;
        }

        /**
         * Creates multiple keys from the parameter. Iteratively invokes the
         * addKey() method.
         *
         * @see				#addKey(string, string)
         *
         * @param header	Name of the header under which these keys will be found.
         * @param keys		A LinkedList of the keys.
         * @return			Returns false if one or more of the keys already exists
         *					under this header.
         */
        public bool addKeys(string header, LinkedList<string> keys)
        {
            if (DEBUG) Console.WriteLine("addKeys('" + header + ",[" + keys.Count() + "keys]') called");
            bool returnable = true;      //will be set to false if any key already exists
            foreach (string k in keys)
            {
                if (!this.addKey(header.ToUpper(), k))
                {
                    returnable = false;     //this is where it's set
                }
            }
            return returnable;
        }

        /**
         * Adds a value under the key and header specified.
         * OVERWRITES ANY VALUE FOR THIS KEY!
         *
         * @param header	Name of the header under which this value will be found.
         * @param key		Name of the key under which this value will be found.
         * @param value		Value of the key.
         */
        public void addValue(string header, string key, string value)
        {
            if (DEBUG) Console.WriteLine("addValue('" + header + "','" + key +
                 "','" + value + "') called");
            header = header.ToUpper();
            this.addKey(header, key);
            this.items[header][key] = value;
        }

        /**
         * Using {@link java.io.FileInputStream FileInputStream} and {@link java.util.Scanner Scanner} reads a file given the
         * file name as the parameter. Proper filename convention to be determined by user.
         *
         * @param fileName	Full path of the file to be read.
         * @return			Returns true if the file read was successful.
         */
        public bool readFile(string fileName)
        {
            if (DEBUG) Console.WriteLine("readFile('" + fileName + "') called");
            StreamReader fileIn;
            int lineNumber = 0;
            bool hasHeader = false;
            string myHeader = "";
            string myLine;
            int indexOfEquals;

            try
            {
                fileIn = new StreamReader(fileName);

                myLine = fileIn.ReadLine();
                lineNumber++;
                while (myLine != null)
                {
                    myLine = myLine.Trim();
                    if (DEBUG) Console.WriteLine(" Line: " + myLine);
                    indexOfEquals = myLine.IndexOf("=");

                    if (myLine.StartsWith("[") && myLine.EndsWith("]") && myLine.LastIndexOf("]") > 1)
                    {
                        myHeader = myLine.Replace("[", "").Replace("]", "").ToUpper();
                        if (DEBUG) Console.WriteLine("  Header: " + myHeader);
                        this.addHeader(myHeader);
                        hasHeader = true;
                    }
                    else if (indexOfEquals >= 0)
                    {
                        if (!hasHeader) Console.WriteLine(" WARNING: No header before key declaration." +
                             "\n Line: " + lineNumber);

                        string myKey = myLine.Substring(0, indexOfEquals).Trim();
                        if (DEBUG) Console.WriteLine("  Key: " + myKey);

                        string myValue = myLine.Substring(indexOfEquals + 1, myLine.Length-indexOfEquals-1).Trim();
                        if (DEBUG) Console.WriteLine("  Value: " + myValue);

                        this.addValue(myHeader, myKey, myValue);
                        keysRead++;
                    }
                    else if (myLine.Equals(""))
                    {
                        //Do nothing if a blank line is found
                    }
                    else
                    {
                        if (DEBUG) Console.WriteLine(" WARNING: Line not formatted properly.");
                        if (DEBUG) Console.WriteLine("\n    Line: " + lineNumber);
                        if (indexOfEquals < 0)
                        {
                            if (DEBUG) Console.WriteLine("        : No '=' found.");
                        }
                        if (!myLine.EndsWith("]"))
                        {
                            if (DEBUG) Console.WriteLine("        : No terminating ']' found.");
                        }
                        if (!myLine.StartsWith("["))
                        {
                            if (DEBUG) Console.WriteLine("        : No beginning '[' found.");
                        }
                        if (myLine.LastIndexOf("]") <= 1)
                        {
                            if (DEBUG) Console.WriteLine("        : No characters between the '[' and ']'.");
                        }
                    }
                    myLine = fileIn.ReadLine();
                    lineNumber++;
                }
                fileIn.Close();
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("ERROR: File not found\n" + e.Message);
                return false;
            }
            catch (IOException e)
            {
                Console.WriteLine("ERROR: File write error\n" + e.Message);
                return false;
            }
            return true;
        }

        /**
         * Using {@link FileOutputStream} and {@link PrintWriter}, writes a file given the
         * file name as the parameter. Proper filename convention to be determined by user.
         *
         * @see				java.io.FileOutputStream
         * @see				java.io.PrintWriter
         *
         * @param fileName	Full path of the file to be written to.
         * @return			Returns true if the file write was successful.
         */
        public bool writeFile(string fileName)
        {
            if (DEBUG) Console.WriteLine("writeFile('" + fileName + "') called");
            StreamWriter fileOut;
            StringBuilder sb;
            try
            {
                fileOut = new StreamWriter(fileName);
                //iterate through the headers and write them to file
                foreach (string header in this.items.Keys)
                {
                    sb = new StringBuilder();
                    sb.Append("[" + header.ToUpper() + "]");
                    if (DEBUG) Console.WriteLine(" " + sb);
                    fileOut.WriteLine(sb.ToString());
                    //iterate through the key under this header and write them to file
                    foreach (string key in this.items[header].Keys)
                    {
                        sb = new StringBuilder();
                        sb.Append(key);
                        sb.Append(" = ");
                        sb.Append(this.items[header][key].ToString());
                        if (DEBUG) Console.WriteLine(" " + sb);
                        fileOut.WriteLine(sb.ToString());
                    }
                }
                fileOut.Close();
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("ERROR: File not found\n" + e.Message);
                return false;
            }
            catch (IOException e)
            {
                Console.WriteLine("ERROR: File write error\n" + e.Message);
                return false;
            }
            return true;
        }

        /**
         * Used the get a list of all the headers.
         *
         * @return	The LinkedList of headers names.
         */
        public LinkedList<string> getHeaders()
        {
            if (DEBUG) Console.WriteLine("getHeaders() called");
            return new LinkedList<string>(this.items.Keys);
        }

        /**
         * Used to get a list of keys under the specified header.
         *
         * @param header	Header of the key names to be returned.
         * @return			The LinkedList of key names matching the header.
         *					Returns null if no such header exists.
         */
        public LinkedList<string> getKeys(string header)
        {
            if (DEBUG) Console.WriteLine("getKeysFromHeader('" + header + "') called");
            header = header.ToUpper();
            if (!this.items.Keys.Contains(header)) return null;
            return new LinkedList<string>(this.items[header].Keys);
        }

        /**
         * Retreives the value of a key under the header.
         *
         * @param header	Header of the key to be returned.
         * @param key		Name of the key to be returned.
         * @return			The value of the key matching the header and key name.
         *					Returns null if no such key or header exists.
         */
        public string getValue(string header, string key)
        {
            if (DEBUG) Console.WriteLine("getValue('" + header + "','" + key + "') called");
            header = header.ToUpper();
            if (!this.items.Keys.Contains(header)) return null;
            return this.items[header][key];//.get() returns null if not found
        }

        /**
         * Toggles whether to activate debug mode or not.
         *
         * @return	The new status of debug mode
         */
        public bool toggleDebug()
        {
            if (DEBUG) Console.WriteLine("toggleDebug() called");
            DEBUG = (!DEBUG);
            return DEBUG;
        }

        /**
         * Used when reading a file after already having declared ("added") the
         * keys and headers included in the program. Be sure to add the
         * headers and keys before reading the file.
         *
         * @see		#addHeader(string header)
         * @see		#addKey(string header, string key)
         * @see		#addKeys(string header, LinkedList keys)
         *
         * @return	Returns true if all keys have been read from file.
         */
        public bool verifyFileRead()
        {
            if (DEBUG) Console.WriteLine("verifyFileRead() called");
            return keysRead >= totalKeys;
        }
    }
}
