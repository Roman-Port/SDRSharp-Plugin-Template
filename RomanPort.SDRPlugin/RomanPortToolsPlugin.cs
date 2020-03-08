using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SDRSharp.Common;

namespace RomanPort.SDRPlugin
{
    public class RomanPortToolsPlugin : ISharpPlugin
    {
        private const string _displayName = "RomanPort Tools";
        private ISharpControl _control;
        private RomanPortToolsPanel _guiControl;

        public UserControl Gui
        {
            get { return _guiControl; }
        }

        public string DisplayName
        {
            get { return _displayName; }
        }

        public void Close()
        {

        }

        public void Initialize(ISharpControl control)
        {
            _control = control;
            _guiControl = new RomanPortToolsPanel();
        }
    }
}