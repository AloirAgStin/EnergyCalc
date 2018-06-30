using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;

namespace KnaufinsulationWalls.Data
{
    public class sBuildingType
    {
        public sBuildingType()
        {

        }
        public String Name { get; set; }
        public int index { get; set; }

        public List<sBuildingWall> data = new List<sBuildingWall>(5);
    }

    public class sBuildingWall
    {
        public sBuildingWall() => Db = 0;

        public String Name { get; set; }
        public int index { get; set; }

        public int Db { get; set; }
        public String Description { get; set; }
    }


    public class Data_BuildingType
    {
        private static List<sBuildingType> data = new List<sBuildingType>(20);
        static public bool InitData()
        {
            var docFileName = Path.Combine(Application.StartupPath, @"data\TypeBuildings.xml");

            //add default data
            data.Clear();
            data.Insert(0, new sBuildingType() { index = 0, Name = "Выберите тип" });
            data[0].data.Add(new sBuildingWall() { Name = "Выберите тип", index = 0 });

            //read data from xml

            var xmldoc = new XmlDocument();
            var fs = new FileStream(docFileName, FileMode.Open, FileAccess.Read);
            xmldoc.Load(fs);
            fs.Close();

            var xmlnode = xmldoc.GetElementsByTagName("BuildingsTypes");

            if (xmlnode.Count == 0)
                return false;

            int iIndex = 1;
            foreach (XmlNode item in xmlnode[0].ChildNodes)
            {
                sBuildingType tp = new sBuildingType();
                tp.index = iIndex++;

                tp.Name = XmlHelper.GetInnerValueXml(item, "Name");

                var listWallsTypes = item["Walls"];
                if (listWallsTypes == null)
                    continue;

                int jIndex = 1;

                tp.data.Add(new sBuildingWall() {  Name = "Выберите тип", index = 0});

                foreach (XmlNode wall in listWallsTypes)
                {
                    sBuildingWall wl = new sBuildingWall();
                    wl.Name = XmlHelper.GetInnerValueXml(wall, "Name");
                    wl.index = jIndex++;
                    wl.Description = XmlHelper.GetInnerValueXml(wall, "Description");

                    String outStr = XmlHelper.GetInnerValueXml(wall, "DbIndex");

                    int number = 0;
                    bool result = Int32.TryParse(outStr, out number);
                    if (!result)
                        continue;

                    wl.Db = number;

                    tp.data.Add(wl);
                }

                data.Add(tp);
            }
            
            return true;

        }
        
        public static List<sBuildingType> GetData()
        {
            return data;
        }

        public static List<sBuildingWall> GetDataByIndex(int index)
        {
            var dt = GetData();
            var item = dt[index];
            return item.data;
        }
    }        
}
