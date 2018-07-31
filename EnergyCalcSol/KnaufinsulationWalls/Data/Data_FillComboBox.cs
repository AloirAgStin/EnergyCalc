using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnaufinsulationWalls.Data
{
    public static class Data_FillComboBox
    {

        public static void InitDataForEIandTP(List<sWalls> _data)
        {
            var MakeChoiseElement = new CBItem();
            MakeChoiseElement.index = 0;
            MakeChoiseElement.Name = "Выберите тип";
            MakeChoiseElement._intValue = 0;

            cbItem_EI.Clear();
            cbItem_TP.Clear();

            foreach (var item in _data)
            {
                foreach (var tp in item.types)
                {
                    var newItmEI = new CBItem() { Name = tp.EI.ToString(), _intValue = tp.EI };
                    var newItmTp = new CBItem() { Name = tp.Tp.ToString(), _intValue = tp.Tp };
                    cbItem_TP.Add(newItmTp);
                    cbItem_EI.Add(newItmEI);
                }
            }

            {
                var uniCompare = new CBItem_EqualityComparerBy_IntValue();
                var uniqList = cbItem_EI.Distinct<CBItem>(uniCompare);
                cbItem_EI = uniqList.ToList<CBItem>();
                cbItem_EI.Sort(ComprasionByIntValue);
                cbItem_EI.Insert(0, MakeChoiseElement);
            }

            {
                var uniCompare = new CBItem_EqualityComparerBy_IntValue();
                var uniqList = cbItem_TP.Distinct<CBItem>(uniCompare);
                MakeChoiseElement.Name = "Выберите толщину";
                cbItem_TP = uniqList.ToList<CBItem>();
                cbItem_TP.Sort(ComprasionByIntValue);
                cbItem_TP.Insert(0, MakeChoiseElement);
            }
        }


        public static void InitDataForEI(List<sWalls> _data)
        {
            var MakeChoiseElement = new CBItem();
            MakeChoiseElement.index = 0;
            MakeChoiseElement.Name = "Выберите тип";
            MakeChoiseElement._intValue = 0;

            cbItem_EI.Clear();

            foreach (var item in _data)
            {
                foreach (var tp in item.types)
                {
                    var newItmEI = new CBItem() { Name = tp.EI.ToString(), _intValue = tp.EI };
                    cbItem_EI.Add(newItmEI);
                }
            }

            {
                var uniCompare = new CBItem_EqualityComparerBy_IntValue();
                var uniqList = cbItem_EI.Distinct<CBItem>(uniCompare);
                cbItem_EI = uniqList.ToList<CBItem>();
                cbItem_EI.Sort(ComprasionByIntValue);
                cbItem_EI.Insert(0, MakeChoiseElement);
            }
        }

        public static void InitDataForTp(List<sWalls> _data)
        {

            cbItem_TP.Clear();

            var MakeChoiseElement = new CBItem();
            MakeChoiseElement.index = 0;
            MakeChoiseElement.Name = "Выберите толщину";
            MakeChoiseElement._intValue = 0;

            foreach (var item in _data)
            {
                foreach (var tp in item.types)
                {
                    var newItmTp = new CBItem() { Name = tp.Tp.ToString(), _intValue = tp.Tp };
                    cbItem_TP.Add(newItmTp);
                }
            }

            {
                var uniCompare = new CBItem_EqualityComparerBy_IntValue();
                var uniqList = cbItem_TP.Distinct<CBItem>(uniCompare);
                cbItem_TP = uniqList.ToList<CBItem>();
                cbItem_TP.Sort(ComprasionByIntValue);
                cbItem_TP.Insert(0, MakeChoiseElement);
            }
        }

        public static void InitDataForTi(List<sWalls> _data)
        {
            cbItem_Ti.Clear();

            var MakeChoiseElement = new CBItem();
            MakeChoiseElement.index = 0;
            MakeChoiseElement.Name = "Выберите толщину";
            MakeChoiseElement._intValue = 0;

            foreach (var item in _data)
            {
                foreach (var tp in item.types)
                {
                     var newItmTi = new CBItem() { Name = tp.Ti.ToString(), _intValue = tp.Ti };
                 
                      cbItem_Ti.Add(newItmTi);
                }
            }

            {
                var uniCompare = new CBItem_EqualityComparerBy_IntValue();
                var uniqList = cbItem_Ti.Distinct<CBItem>(uniCompare);
                cbItem_Ti = uniqList.ToList<CBItem>();
                cbItem_Ti.Sort(ComprasionByIntValue);
                cbItem_Ti.Insert(0, MakeChoiseElement);
            }
        }

        public static void InitDataForN(List<sWalls> _data)
        {
            var MakeChoiseElement = new CBItem();
            MakeChoiseElement.index = 0;
            MakeChoiseElement.Name = "Выберите количество";
            MakeChoiseElement._intValue = 0;
            cbItem_N.Clear();

            foreach (var item in _data)
            {
                foreach (var tp in item.types)
                {
                         var newItmN = new CBItem() { Name = tp.N.ToString(), _intValue = tp.N };

                        cbItem_N.Add(newItmN);
                }
            }

            {
                var uniCompare = new CBItem_EqualityComparerBy_IntValue();
                var uniqList = cbItem_N.Distinct<CBItem>(uniCompare);
                cbItem_N = uniqList.ToList<CBItem>();
                cbItem_N.Sort(ComprasionByIntValue);

                MakeChoiseElement.Name = "Выберите количество";
                cbItem_N.Insert(0, MakeChoiseElement);
            }
        }

        /*
        public static bool InitDataForFill(List<sWalls> _data)
        {
            var MakeChoiseElement = new CBItem();
            MakeChoiseElement.index = 0;
            MakeChoiseElement.Name = "Выберите тип";
            MakeChoiseElement._intValue = 0;

            cbItem_EI.Clear();
            cbItem_TP.Clear();
            cbItem_Ti.Clear();
            cbItem_N.Clear();

            foreach (var item in _data)
            {
                foreach (var tp in item.types)
                {
                    var newItmEI = new CBItem() { Name = tp.EI.ToString(), _intValue = tp.EI };
                    var newItmTp = new CBItem() { Name = tp.Tp.ToString(), _intValue = tp.Tp};
                    var newItmTi = new CBItem() { Name = tp.Ti.ToString(), _intValue = tp.Ti};
                    var newItmN = new CBItem() { Name = tp.N.ToString(), _intValue = tp.N };
                    
                    cbItem_EI.Add(newItmEI);
                    cbItem_TP.Add(newItmTp);
                    cbItem_Ti.Add(newItmTi);
                    cbItem_N.Add(newItmN);
                }
            }

            {
                var uniCompare = new CBItem_EqualityComparerBy_IntValue();
                var uniqList = cbItem_EI.Distinct<CBItem>(uniCompare);
                cbItem_EI = uniqList.ToList<CBItem>();
                cbItem_EI.Sort(ComprasionByIntValue);
                cbItem_EI.Insert(0, MakeChoiseElement);
            }
            {
                var uniCompare = new CBItem_EqualityComparerBy_IntValue();
                var uniqList = cbItem_TP.Distinct<CBItem>(uniCompare);
                cbItem_TP = uniqList.ToList<CBItem>();
                cbItem_TP.Sort(ComprasionByIntValue);

                MakeChoiseElement.Name = "Выберите толщину";
                cbItem_TP.Insert(0, MakeChoiseElement);
            }
            {
                var uniCompare = new CBItem_EqualityComparerBy_IntValue();
                var uniqList = cbItem_Ti.Distinct<CBItem>(uniCompare);
                cbItem_Ti = uniqList.ToList<CBItem>();
                cbItem_Ti.Sort(ComprasionByIntValue);

                cbItem_Ti.Insert(0, MakeChoiseElement);
            }
            {
                var uniCompare = new CBItem_EqualityComparerBy_IntValue();
                var uniqList = cbItem_N.Distinct<CBItem>(uniCompare);
                cbItem_N = uniqList.ToList<CBItem>();
                cbItem_N.Sort(ComprasionByIntValue);
                
                MakeChoiseElement.Name = "Выберите количество";
                cbItem_N.Insert(0, MakeChoiseElement);
            }
           
            return true;
        }
        */


        public static List<CBItem> cbItem_EI = new List<CBItem>();

        public static List<CBItem> cbItem_TP = new List<CBItem>();

        public static List<CBItem> cbItem_Ti = new List<CBItem>();

        public static List<CBItem> cbItem_N = new List<CBItem>();


        public static int ComprasionByIntValue(CBItem x, CBItem y)
        {
            if (x._intValue == y._intValue)
                return 0;

            if (x._intValue > y._intValue)
                return 1;
            
            return -1;
        }

        class CBItem_EqualityComparerBy_IntValue : IEqualityComparer<CBItem>
        {
            public bool Equals(CBItem b1, CBItem b2)
            {
                if (b1._intValue == b2._intValue)
                    return true;
                else
                    return false;
            }

            public int GetHashCode(CBItem bx)
            {
                int hCode = bx._intValue ^ 123;
                return hCode.GetHashCode();
            }
            
        }

        public struct CBItem
        {
            public String Name { get; set; }
            public int index { get; set; }
            public int _intValue { get; set; }
        }        
    }

}
