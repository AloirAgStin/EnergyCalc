using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace KnaufinsulationWalls.Data
{
    public static class Data_WallsType
    {
        public static List<sWalls> data = new List<sWalls>(10);

        public class sWalls : ICloneable
        {
            public String Name;
            public String Description;
            public List<sWallsTypes> types = new List<sWallsTypes>(5);

            public object Clone()
            {
                var item = new sWalls();
                item.Description = Description;
                item.Name = Name;
                item.types = types.ToList();
                return item;
            }
        }
        public class sWallsTypes
        {
            public sWallsTypes()
            {
                Tp = 0;
                Ti = 0;
                Rw = 0;
                EI = 0;
                N = 0;
                ImageName = "";
            }

            public int Rw;
            public int Tp;
            public int EI;


            public int Ti;
            public int N;
            public String ImageName;

            public List<sFile> _files = new List<sFile>(6);

        }

        public class sFile : ICloneable
        {
            public enum _type
            {
                FileName,
                FileDescription
            };

            public sFile(_type t, String value)
            {
                type = t;
                if (t == _type.FileName)
                    FileName = value;
                else
                    ExtInfo = value;
            }

            public String FileName;
            public String ExtInfo;

            public _type type;

            public object Clone()
            {
                var t = new sFile(type, "");
                t.ExtInfo = ExtInfo;
                t.FileName = FileName;

                return t;
            }
        }
        
        public static List<sWalls> GetFilerData(CalcItem userFilter)
        {
            List<sWalls> itemCalc = new List<sWalls>();
         
            foreach(var itm in data)
                itemCalc.Add((sWalls)itm.Clone());
            
            foreach (var item in itemCalc)
            {
                item.types.RemoveAll(x => x.Tp  != userFilter.Tp);
                item.types.RemoveAll(x => x.EI < userFilter.EI);
                item.types.RemoveAll(x => x.Rw < userFilter.Rw);
                
                if (userFilter.Ti != 0)
                    item.types.RemoveAll(x => x.Ti != userFilter.Ti);

                if (userFilter.N != 0)
                   item.types.RemoveAll(x => x.N < userFilter.N);
            }

            itemCalc.RemoveAll(x => x.types.Count == 0);


            return itemCalc;
        }

        public static List<sLineWallsStruct> GetLineStruct(List<sWalls> data)
        {
            List<sLineWallsStruct> newData = new List<sLineWallsStruct>();

            data.ForEach(delegate(sWalls item)
            {
                item.types.ForEach(delegate (sWallsTypes fl)
                {
                    sLineWallsStruct newItm = new sLineWallsStruct() { Name = item.Name, Description = item.Description };
                    newItm.WallTypes = fl;
                    newData.Add(newItm);

                });                
            });
           

            return newData;
        }
    
        public class sLineWallsStruct
        {
            public String Name;
            public String Description;
            public sWallsTypes WallTypes;

            public String GetNameExtVal()
            {
                int pos1= Name.IndexOf("(");
                int pos2 = Name.IndexOf(")");
                if (pos1 < pos2 && pos1!= pos2 && pos1 != -1 && pos2 != -1)
                    return Name.Substring(pos1, pos2-pos1 + 1);

                return "";
            }
        }

        public static bool InitData()
        {
            var docFileName = Path.Combine(Application.StartupPath, @"data\TypeWalls.xml");
            
            data.Clear();

            var xmldoc = new XmlDocument();
            var fs = new FileStream(docFileName, FileMode.Open, FileAccess.Read);
            xmldoc.Load(fs);
            fs.Close();


            var xmlnode = xmldoc.GetElementsByTagName("WallsType");

            if (xmlnode.Count == 0)
                return false;

            foreach (XmlNode item in xmlnode[0].ChildNodes)
            {
                sWalls tp = new sWalls();

                tp.Name = XmlHelper.GetInnerValueXml(item, "Name");
                tp.Description = XmlHelper.GetInnerValueXml(item, "Description");


                var listWallsTypes = item["Types"];
                if (listWallsTypes == null)
                    continue;
                
                foreach (XmlNode wall in listWallsTypes)
                {
                    var wl = new sWallsTypes();

                    if (!XmlHelper.GetAttribute(wall, "Tp", out wl.Tp))
                        continue;
                    
                    if (!XmlHelper.GetAttribute(wall, "Tu", out wl.Ti))
                        continue;

                    if (!XmlHelper.GetAttribute(wall, "Rw", out wl.Rw))
                        continue;

                    if (!XmlHelper.GetAttribute(wall, "EI", out wl.EI))
                        continue;
                    
                    if (!XmlHelper.GetAttribute(wall, "N", out wl.N))
                        continue;

                    XmlHelper.GetAttribute(wall, "Img", out wl.ImageName);


                    var xmlnodeFiles = wall["Files"];
                    if (xmlnodeFiles != null)
                    {
                        foreach (XmlNode fl in xmlnodeFiles)
                        {

                            var type = sFile._type.FileName;
                            String value = fl.InnerText;
                            if (value == null)
                            {
                                type = sFile._type.FileDescription;
                                XmlHelper.GetAttribute(fl, "Text", out value);
                                if (value == null || value.Length == 0)
                                    value = "Ошибка извлечения имени файла или текста описания";
                            }
                            sFile file = new sFile(type, value);

                            wl._files.Add(file);
                        }
                    }
                    else
                    {
                        if (tp.types.Count > 0)
                        {
                            foreach (var itm in tp.types[0]._files)
                                wl._files.Add((sFile)itm.Clone());
                        }
                    }
                    
                    tp.types.Add(wl);
                }
             
                data.Add(tp);
            }        
            
            return true;
        }





    }
}
