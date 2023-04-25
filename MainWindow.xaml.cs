using System;
using System.Diagnostics;
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

namespace Lab___Deconstruct_Objects_to_Classes
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


        private void BtnSoccerball_Click(object sender, RoutedEventArgs e)
        {
            BrandType brand = (BrandType)cmbBrand.SelectedIndex;
            SizeOfBall size = (SizeOfBall)CmbSize.SelectedIndex;
            int yearMade = int.Parse(TxtYearmade.Text);
          

            MessageBox.Show($"soccer Ball wishlist: \nBrand: {brand}\nYear Made: {yearMade}\nSize: {size}");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Beats Beats = (Beats)CmbBeats.SelectedIndex;
            driverSize driverSize = (driverSize)CmbdriverSize.SelectedIndex;
            FrequencyResponse FrequencyResponse = (FrequencyResponse)CmbFrequencyResponse.SelectedIndex;
            int year = int .Parse(TxtYear1.Text);



            MessageBox.Show($"Beats by Dre Wishlist :\nModel : {Beats}\n Year : {year}\n driverSize : {driverSize} \n FrequencyResponse : {FrequencyResponse}");


        }

        private void Btnsunglasses_Click(object sender, RoutedEventArgs e)
        {

            sunglassesHut sunglassesHut =(sunglassesHut)CmbHut.SelectedIndex;

            version version = (version)CmbLens.SelectedIndex;

            LensWidth LensWidth = (LensWidth)CmbWidth.SelectedIndex;
            
            LensHeight lensHeight = (LensHeight)CmbHeight.SelectedIndex;



            MessageBox.Show($"The sunglasses hut Presents: \n\n Brand: {sunglassesHut}\n version: {version}\n LensWidth: {LensWidth} \n lensHeight: {lensHeight}");


        }

        private void BtnSaveall_Click(object sender, RoutedEventArgs e)

        {
            Bike Bike = new Bike();

            BrandType brand = (BrandType)cmbBrand.SelectedIndex;

            Beats Beats = (Beats)CmbBeats.SelectedIndex;
            Watch watch = (Watch)CmbWatch.SelectedIndex;
            Bike.Brand = TxtBrand1.Text;


            sunglassesHut sunglassesHut = (sunglassesHut)CmbHut.SelectedIndex;

            MessageBox.Show($"my bithday wishlist \n\n sunglasses: {sunglassesHut}\n beats: {Beats}\n soccer ball: {brand}\n Wrist watch: {watch}\n Bike {Bike.Brand}");

           
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Watch watch = (Watch)CmbWatch.SelectedIndex;
            YearMade yearMade = (YearMade)CmbWatch.SelectedIndex;
            CaseMaterial caseMaterial = (CaseMaterial)CmbCaseMaterial.SelectedIndex;
            int price = int.Parse(Txtprice.Text);

            MessageBox.Show($"Wrist watch : \n\n Watch: {watch}\n time period : {yearMade}\n Material: {caseMaterial} \n make an Offer: ${price}");


        }

        private void BtnBike_Click(object sender, RoutedEventArgs e)
        {
            Bike Bike = new Bike();
            Bike.Brand = TxtBrand1.Text;
            Bike.Color = TxtColor.Text;

            Wheels wheels = (Wheels)CmbWheels.SelectedIndex;

            MessageBox.Show($"Bike: \n\n Brand: {Bike.Brand}\n the color: {Bike.Color}\n wheels: {wheels} \n ");


        }
    }
}
