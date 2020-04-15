using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Drawing
{
    /// <summary>
    /// Interaction logic for GroupedShapes.xaml
    /// </summary>

    public partial class GroupedShapes : System.Windows.Window
    {
        private RectangleGeometry newRectangleGeometry;

        public GroupedShapes()
        {
            InitializeComponent();
            newRectangleGeometry = new RectangleGeometry();
            newRectangleGeometry.Rect = new Rect(0, 0, 50, 50);
            ((GeometryGroup)(path.Data)).Children.Add(newRectangleGeometry);
            //Console.WriteLine(path.Data.GetType());//.AddChild(newButton);
        }

    }
}