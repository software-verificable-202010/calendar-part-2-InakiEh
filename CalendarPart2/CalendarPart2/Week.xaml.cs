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
using System.Windows.Shapes;

namespace CalendarPart2
{
    /// <summary>
    /// Lógica de interacción para Week.xaml
    /// </summary>
    public partial class Week : Window
    {
        MainWindow MainWindow = new MainWindow();
        Appointment Appointment = new Appointment();
        int weekCounter = 0;


        #region main
        public Week()
        {
            InitializeComponent();
            CreateAppointments();
            LoadCurrentWeek();
        }
        #endregion

        #region Methods
        public void CreateAppointments()
        {
            List<Appointment> appointments = Appointment.GetAppointmentsList();
            DateTime today = DateTime.Today;
        }
        private void InsertTheAppointmens(List<Appointment> appointments, List<string> daysOfWeek, List<DateTime> dates, int weekCounter, Grid hourCells)
        {
            foreach (var appointment in appointments)
            {
                int firstDayOfWeek = 0;
                int lastDayOfWeek = 6;
                int totalDaysOnWeek = 7;

                if (appointment.date >= dates[firstDayOfWeek].AddDays(totalDaysOnWeek * weekCounter) && appointment.date <= dates[lastDayOfWeek].AddDays(totalDaysOnWeek * weekCounter))
                {
                    bool firstButtonOfAppointment = true;
                    int startHour = appointment.fromHour;
                    int endHour = appointment.toHour;
                    while (startHour <= endHour)
                    {
                        insertAppointmentOnCell(firstButtonOfAppointment, appointment, daysOfWeek, startHour);
                    }
                }
            }
        }
        public void insertAppointmentOnCell(bool firstButtonOfAppointment, Appointment appointment, List<string> daysOfWeek, int startHour)
        {
            Button dynamicButton = new Button();
            if (firstButtonOfAppointment == true)
            {
                dynamicButton.Content = appointment.title;
                firstButtonOfAppointment = false;
            }

            hourCells.Children.Add(dynamicButton);
            int dayOfAppointment = daysOfWeek.IndexOf(appointment.date.DayOfWeek.ToString());
            Grid.SetColumn(dynamicButton, dayOfAppointment);
            Grid.SetRow(dynamicButton, startHour);
            startHour += 1;
        }
        public void LoadCurrentWeek()
        {
            ReloadInterface(weekCounter);

        }
        private void LoadPreviousWeek(object sender, RoutedEventArgs e)
        {
            weekCounter -= 1;
            ReloadInterface(weekCounter);

        }
        private void LoadNewWeek(object sender, RoutedEventArgs e)
        {
            weekCounter += 1;
            ReloadInterface(weekCounter);

        }
        public void ReloadInterface(int weekCounter)
        {
            List<string> weeks = MainWindow.GetWeeksList();
            List<Appointment> appointments = Appointment.GetAppointmentsList();
            List<string> months = MainWindow.GetMonthsList();
            DateTime today = DateTime.Today;
            int currentDayOfWeek = (int)today.DayOfWeek;
            DateTime sunday = today.AddDays(-currentDayOfWeek);
            DateTime monday = sunday.AddDays(1);
            hourCells.Children.Clear();

            ChangeInterface(currentDayOfWeek, monday, weeks, appointments, months);
            
        }
        public void ChangeInterface(int currentDayOfWeek, DateTime monday, List<string> weeks, List<Appointment> appointments, List<string> months)
        {
            if (currentDayOfWeek == 0)
            {
                monday = monday.AddDays(-7);
            }
            var dates = Enumerable.Range(0, 7).Select(days => monday.AddDays(days)).ToList();

            mondayNumber.Content = dates[0].Date.AddDays(7 * weekCounter).Day;
            tuesdayNumber.Content = dates[1].Date.AddDays(7 * weekCounter).Day;
            wednesdayNumber.Content = dates[2].Date.AddDays(7 * weekCounter).Day;
            thursdayNumber.Content = dates[3].Date.AddDays(7 * weekCounter).Day;
            fridayNumber.Content = dates[4].Date.AddDays(7 * weekCounter).Day;
            saturdayNumber.Content = dates[5].Date.AddDays(7 * weekCounter).Day;
            sundayNumber.Content = dates[6].Date.AddDays(7 * weekCounter).Day;

            weekMonth.Text = months[(dates[0].Date.AddDays(7 * weekCounter).Month) - 1] + " " + dates[0].Date.AddDays(7 * weekCounter).Year;
            InsertTheAppointmens(appointments, weeks, dates, weekCounter, hourCells);
        }
        #endregion
    }
}
