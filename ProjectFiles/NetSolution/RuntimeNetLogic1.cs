#region Using directives
using System;
using UAManagedCore;
using OpcUa = UAManagedCore.OpcUa;
using FTOptix.SQLiteStore;
using FTOptix.HMIProject;
using FTOptix.UI;
using FTOptix.DataLogger;
using FTOptix.NativeUI;
using FTOptix.CoreBase;
using FTOptix.Store;
using FTOptix.RAEtherNetIP;
using FTOptix.System;
using FTOptix.Retentivity;
using FTOptix.NetLogic;
using FTOptix.CommunicationDriver;
using FTOptix.SerialPort;
using FTOptix.UI;
using FTOptix.Core;
using FTOptix.WebUI;
using FTOptix.Modbus;
using FTOptix.Alarm;
#endregion

public class RuntimeNetLogic1 : BaseNetLogic
{
    public override void Start()
    {

        // Insert code to be executed when the user-defined logic is started

        DataGrid dataGrid = (DataGrid)Owner;
        dataGrid.SelectedItem = NodeId.Empty;


    }

    public override void Stop()
    {
        // Insert code to be executed when the user-defined logic is stopped
    }
}
