using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using KnaufinsulationWalls.Data;

namespace KnaufinsulationWalls
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        /// 
        static DateTime dt = new DateTime(2018, 7, 6);
        static DateTime dtEnd = dt;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Helper.WriteLog("---------------------------------------------");
            Helper.WriteLog("Запуск программы " + Application.StartupPath);

            dtEnd = new DateTime(2018, 7, 18);

            /*if (DateTime.Now > dtEnd || DateTime.Now < dt)
            {
                MessageBox.Show("Бета версия приложения закончилась. Обратитесь к разработчику");
                return;
            }
            */

            try
            {
                if (!Data_BuildingType.InitData())
                    throw new Exception("Ошибка инициализации данных");
            }
            catch(Exception ex)
            {
                string message = ex.Message;
                message += "\r\n\r\nОшибка чтение данных из файла TypeBuildings.xml\r\nПриложение будет закрыто!";

                MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Helper.WriteLog(message);

                Application.Exit();
                return;
            }


            try
            {
                if(!Data_WallsType.InitData())
                    throw new Exception("Ошибка инициализации данных");
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                message += "\r\n\r\nОшибка чтение данных из файла TypeWalls.xml\r\nПриложение будет закрыто!";

                MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Helper.WriteLog(message);

                Application.Exit();
                return;
            }

            try
            {
                if(!Data_FillComboBox.InitDataForFill())
                throw new Exception("Ошибка инициализации данных для элементов управления");
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                message += "\r\n\r\nПриложение будет закрыто!";

                MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Helper.WriteLog(message);

                Application.Exit();
                return;
            }
            
            //Application.Run(new Steps.StepFrame());
            Application.Run(new MainForm());
        }
    }
}
