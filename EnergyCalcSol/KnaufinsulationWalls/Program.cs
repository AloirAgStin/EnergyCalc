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
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
      
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


            Application.Run(new Steps.StepFrame());
            //Application.Run(new MainForm());


        }
    }
}
