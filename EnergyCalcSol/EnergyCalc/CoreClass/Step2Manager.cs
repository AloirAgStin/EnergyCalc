using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XCtrl;

namespace EnergyCalc.CoreClass
{
    static class Step2Manager
    {
        private static List<sExtDataSource> buildingTypeList = new List<sExtDataSource>()
        {
            new sExtDataSource() { Code = 1, Name = "Здание без подвала. Неотапливаемая мансарда." },
            new sExtDataSource() { Code = 2, Name = "Здание без подвала. Отапливаемая мансарда." },
            new sExtDataSource() { Code = 3, Name = "Здание с неотапливаемым подвалом. Неотапливаемая мансарда." },
            new sExtDataSource() { Code = 4, Name = "Здание с неотапливаемым подвалом. Отапливаемая мансарда." },
            new sExtDataSource() { Code = 5, Name = "Здание с отапливаемым подвалом. Неотапливаемая мансарда." },
            new sExtDataSource() { Code = 6, Name = "Здание с отапливаемым подвалом. Отапливаемая мансарда." }
        };

        public static List<sExtDataSource> GetBuilingList()
        {
            return buildingTypeList;
        }




    }
}
