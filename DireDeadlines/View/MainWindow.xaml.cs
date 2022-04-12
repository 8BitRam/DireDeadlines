using System;
using System.Collections.Generic;
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

namespace DireDeadlines
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}

//Create New Project XAML
/*
 *     <Grid Margin="10">

        <Grid.RowDefinitions>
            <RowDefinition Height="*" />
            <RowDefinition Height="*" />
        </Grid.RowDefinitions>
        <Button x:Name="CreateNewFile" Content="Create New DaD File" HorizontalAlignment="Center" VerticalAlignment="Center" Margin="0,0,0,0" 
                Click="ButtonNewDaD_Click" FontStyle="Normal" FontWeight="Bold" FontFamily="Consolas" FontSize="18"/>
        <Button x:Name="LoadFile" Content="Load Existing DaD File" HorizontalAlignment="Center" VerticalAlignment="Center" Margin="0,0,0,0" Grid.Row="1"
                Click="ButtonLoadDaD_Click" FontStyle="Normal" FontWeight="Bold" FontFamily="Consolas" FontSize="18"/>
    </Grid>
 */
