﻿using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Runtime.CompilerServices;
using gcafePrnConsole;

using System.Data.OleDb;

namespace gcafeSvc
{
    public class gcafePrn : IgcafePrn, IDisposable
    {
        private bool _isStop = false;
        private Thread _thrPrint = null;
        //private PrintTaskMgr _printTaskMgr;

        public gcafePrn()
        {
            //_printTaskMgr = new PrintTaskMgr();
            //_thrPrint = new Thread(new ThreadStart(PrintThread));
            //_thrPrint.Start();
        }

        private void PrintThread()
        {
            while (!_isStop)
            {
                Thread.Sleep(1000);
                System.Diagnostics.Debug.WriteLine(".");
            }

            System.Diagnostics.Debug.WriteLine("***************++++++++++++++++++++++++++++========================");
        }

        public string PrintLiuTai(int orderId, int prnType, bool rePrint = false)
        {
            Global.Logger.Trace(Global.TraceMessage());

            try
            {
                //_printTaskMgr.AddTask(new PrintTask(PrintTask.PrintType.PrintHuaDan, 1, -1));
                //System.Windows.Application.Current.Dispatcher.Invoke(System.Windows.Threading.DispatcherPriority.Background, new DoTask(Print), printTask);
                //_printTaskMgr.Print(new PrintTask(PrintTask.PrintType.PringHuaDan, 1, -1));
                Global.PrintTaskMgr.AddTask(new PrintTask(PrintTask.PrintType.PrintLiuTai, orderId, prnType, rePrint));
            }
            catch (Exception ex)
            {
                Global.Logger.Error(string.Format("{0}, msg:{1}", Global.TraceMessage(), ex.Message));
            }

            Global.Logger.Trace(Global.TraceMessage());

            return "";
        }

        public string PrintHuaDan(int orderId, int prnType, bool rePrint = false)
        {
            Global.Logger.Trace(Global.TraceMessage());

            try
            {
                Global.PrintTaskMgr.AddTask(new PrintTask(PrintTask.PrintType.PrintHuaDan, orderId, prnType, rePrint));
            }
            catch (Exception ex)
            {
                Global.Logger.Error(string.Format("{0}, msg:{1}", Global.TraceMessage(), ex.Message));
            }

            Global.Logger.Trace(Global.TraceMessage());

            return "";
        }

        public string PrintChuPing(int orderId, int prnType, bool rePrint = false)
        {
            Global.Logger.Trace(Global.TraceMessage());

            try
            {
                Global.PrintTaskMgr.AddTask(new PrintTask(PrintTask.PrintType.PrintChuPin, orderId, prnType, rePrint));
            }
            catch (Exception ex)
            {
                Global.Logger.Error(string.Format("{0}, msg:{1}", Global.TraceMessage(), ex.Message));
            }

            Global.Logger.Trace(Global.TraceMessage());

            return "";
        }

        public string OrderPrint(int orderId, int prnType, bool rePrint = false)
        {
            Global.Logger.Trace(Global.TraceMessage());

            try
            {
                Global.PrintTaskMgr.AddTask(new PrintTask(PrintTask.PrintType.OrderPrint, orderId, prnType, rePrint));
            }
            catch (Exception ex)
            {
                Global.Logger.Error(string.Format("{0}, msg:{1}", Global.TraceMessage(), ex.Message));
            }

            Global.Logger.Trace(Global.TraceMessage());

            return "";
        }

        public string PrintChuPingCui(int orderId, int orderDetailId, int setmailId)
        {
            Global.Logger.Trace(Global.TraceMessage());

            try
            {

            }
            catch (Exception ex)
            {
                Global.Logger.Error(string.Format("{0}, msg:{1}", Global.TraceMessage(), ex.Message));
            }

            Global.Logger.Trace(Global.TraceMessage());

            return "";
        }

        public string OpenTable(string orderNum, string tableNum, string staffName, int customerNum)
        {
            Global.Logger.Trace(Global.TraceMessage());

            try
            {
                using (var conn = new OleDbConnection(Global.FoxproPath))
                {
                    conn.Open();

                    string sql = string.Format("INSERT INTO orders(orderno, ordertime, custkind, personum, waiter, tableno, paid) VALUES('{0}', {4}, ' ', {1}, '{2}', '{3}', 0)",
                        orderNum, customerNum, staffName, tableNum, "{ fn NOW() }");

                    OleDbCommand cmd = new OleDbCommand(sql, conn);
                    cmd.ExecuteNonQuery();

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                Global.Logger.Error(string.Format("{0}, msg:{1}", Global.TraceMessage(), ex.Message));
            }

            Global.Logger.Trace(Global.TraceMessage());

            return "";
        }

        public void Dispose()
        {
            _isStop = true;
            System.Diagnostics.Debug.WriteLine("============================================================");
            //_printTaskMgr.Dispose();
        }
    }
}
