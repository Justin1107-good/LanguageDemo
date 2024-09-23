using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace LanguageDemo
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SetDefaultLang();
        }
        //国际化默认使用系统语言环境
        private void SetDefaultLang()
        {
            CultureInfo currentCulture = CultureInfo.CurrentCulture;
            string systemLanguage = currentCulture.TwoLetterISOLanguageName; // 返回两个字母的语言简写，例如"en"代表英语，"zh"代表中文

            bool isCn = "en".Equals(systemLanguage);

            if (isCn == true)
            {
                LanguageManager.Instance.ChangeLanguage(new CultureInfo("en-US"));
               
            }
            else
            {
                LanguageManager.Instance.ChangeLanguage(new CultureInfo("zh-CN"));
            }
        }
        private void menuItemZHCN_Click(object sender, RoutedEventArgs e)
        {
            LanguageManager.Instance.ChangeLanguage(new CultureInfo("zh-CN"));
        } 
        private void menuItemEN_Click(object sender, RoutedEventArgs e)
        {
            LanguageManager.Instance.ChangeLanguage(new CultureInfo("en-US"));
        }
    }
}
