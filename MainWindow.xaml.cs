using ICSharpCode.Decompiler;
using ICSharpCode.Decompiler.CSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Decompile
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var fileName = @"C:\Temp\BinarDataGenerator.dll";

            var decompiler = new CSharpDecompiler(fileName, new DecompilerSettings());
            string code = decompiler.DecompileWholeModuleAsString();
            Debug.WriteLine(code);
        }
    }
}
