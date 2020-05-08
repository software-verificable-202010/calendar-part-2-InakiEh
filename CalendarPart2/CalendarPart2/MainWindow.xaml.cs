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

namespace CalendarPart2
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Appointment Appointment = new Appointment();

        #region lists

        List<string> weeks = new List<string>();
        List<string> months = new List<string>();
        List<Label> numbersOfDays = new List<Label>();
        List<StackPanel> cells = new List<StackPanel>();
        List<string> hours = new List<string>();

        #endregion

        #region main
        public MainWindow()
        {
            InitializeComponent();
            ShowCalendar();
        }
        #endregion

        #region methods
        public void ShowCalendar()
        {
            List<Appointment> appointments = Appointment.GetAppointmentsList();
            FillLists();
            SetCalendarDefaults();
            string monthSelected = monthSelector.Text;
            string yearSelected = yearSelector.Text;

            GenerateDates(monthSelected, yearSelected, appointments);
        }
        public void FillLists()
        {
            FillWeekList(weeks);
            FillMonthsList(months);
            FillLabelsList(numbersOfDays);
            FillCellsList(cells);
            FillHoursList(hours);
            FillFromHourComboBox(fromHourSelector);
            FillToHourComboBox(toHourSelector);
            FillMonthComboBox(monthSelector);
            FillYearList();
        }
        private void FillWeekList(List<string> weeks)
        {
            weeks.Add("Monday");
            weeks.Add("Tuesday");
            weeks.Add("Wednesday");
            weeks.Add("Thursday");
            weeks.Add("Friday");
            weeks.Add("Saturday");
            weeks.Add("Sunday");

        }
        private void FillMonthsList(List<string> months)
        {
            months.Add("January");
            months.Add("February");
            months.Add("March");
            months.Add("April");
            months.Add("May");
            months.Add("June");
            months.Add("July");
            months.Add("August");
            months.Add("September");
            months.Add("October");
            months.Add("November");
            months.Add("Dicember");
        }
        private void FillLabelsList(List<Label> numbersOfDays)
        {
            numbersOfDays.Add(dateNumber1);
            numbersOfDays.Add(dateNumber2);
            numbersOfDays.Add(dateNumber3);
            numbersOfDays.Add(dateNumber4);
            numbersOfDays.Add(dateNumber5);
            numbersOfDays.Add(dateNumber6);
            numbersOfDays.Add(dateNumber7);
            numbersOfDays.Add(dateNumber8);
            numbersOfDays.Add(dateNumber9);
            numbersOfDays.Add(dateNumber10);
            numbersOfDays.Add(dateNumber11);
            numbersOfDays.Add(dateNumber12);
            numbersOfDays.Add(dateNumber13);
            numbersOfDays.Add(dateNumber14);
            numbersOfDays.Add(dateNumber15);
            numbersOfDays.Add(dateNumber16);
            numbersOfDays.Add(dateNumber17);
            numbersOfDays.Add(dateNumber18);
            numbersOfDays.Add(dateNumber19);
            numbersOfDays.Add(dateNumber20);
            numbersOfDays.Add(dateNumber21);
            numbersOfDays.Add(dateNumber22);
            numbersOfDays.Add(dateNumber23);
            numbersOfDays.Add(dateNumber24);
            numbersOfDays.Add(dateNumber25);
            numbersOfDays.Add(dateNumber26);
            numbersOfDays.Add(dateNumber27);
            numbersOfDays.Add(dateNumber28);
            numbersOfDays.Add(dateNumber29);
            numbersOfDays.Add(dateNumber30);
            numbersOfDays.Add(dateNumber31);
            numbersOfDays.Add(dateNumber32);
            numbersOfDays.Add(dateNumber33);
            numbersOfDays.Add(dateNumber34);
            numbersOfDays.Add(dateNumber35);
            numbersOfDays.Add(dateNumber36);
            numbersOfDays.Add(dateNumber37);
            numbersOfDays.Add(dateNumber38);
            numbersOfDays.Add(dateNumber39);
            numbersOfDays.Add(dateNumber40);
            numbersOfDays.Add(dateNumber41);
            numbersOfDays.Add(dateNumber42);
        }
        private void FillCellsList(List<StackPanel> cells)
        {
            cells.Add(dateSquare1);
            cells.Add(dateSquare2);
            cells.Add(dateSquare3);
            cells.Add(dateSquare4);
            cells.Add(dateSquare5);
            cells.Add(dateSquare6);
            cells.Add(dateSquare7);
            cells.Add(dateSquare8);
            cells.Add(dateSquare9);
            cells.Add(dateSquare10);
            cells.Add(dateSquare11);
            cells.Add(dateSquare12);
            cells.Add(dateSquare13);
            cells.Add(dateSquare14);
            cells.Add(dateSquare15);
            cells.Add(dateSquare16);
            cells.Add(dateSquare17);
            cells.Add(dateSquare18);
            cells.Add(dateSquare19);
            cells.Add(dateSquare20);
            cells.Add(dateSquare21);
            cells.Add(dateSquare22);
            cells.Add(dateSquare23);
            cells.Add(dateSquare24);
            cells.Add(dateSquare25);
            cells.Add(dateSquare26);
            cells.Add(dateSquare27);
            cells.Add(dateSquare28);
            cells.Add(dateSquare29);
            cells.Add(dateSquare30);
            cells.Add(dateSquare31);
            cells.Add(dateSquare32);
            cells.Add(dateSquare33);
            cells.Add(dateSquare34);
            cells.Add(dateSquare35);
            cells.Add(dateSquare36);
            cells.Add(dateSquare37);
            cells.Add(dateSquare38);
            cells.Add(dateSquare39);
            cells.Add(dateSquare40);
            cells.Add(dateSquare41);
            cells.Add(dateSquare42);

        }
        public void FillHoursList(List<string> hours)
        {
            hours.Add("1am");
            hours.Add("2am");
            hours.Add("3am");
            hours.Add("4am");
            hours.Add("5am");
            hours.Add("6am");
            hours.Add("7am");
            hours.Add("8am");
            hours.Add("9am");
            hours.Add("10am");
            hours.Add("11am");
            hours.Add("12am");
            hours.Add("1pm");
            hours.Add("2pm");
            hours.Add("3pm");
            hours.Add("4pm");
            hours.Add("5pm");
            hours.Add("6pm");
            hours.Add("7pm");
            hours.Add("8pm");
            hours.Add("9pm");
            hours.Add("10pm");
            hours.Add("11pm");
            hours.Add("12pm");
        }
        public void FillFromHourComboBox(ComboBox fromHour)
        {
            foreach (string hour in hours)
            {
                fromHour.Items.Add(hour);
            }
        }
        public void FillToHourComboBox(ComboBox ToHour)
        {
            foreach (string hour in hours)
            {
                ToHour.Items.Add(hour);
            }
        }
        public void FillMonthComboBox(ComboBox monthSelector)
        {
            foreach (string month in months)
            {
                monthSelector.Items.Add(month);
            }
        }
        public void FillYearList()
        {
            int minYear = 1930;
            int maxYear = 2050;
            IEnumerable<int> years = Enumerable.Range(minYear, maxYear - minYear + 1);
            foreach (int year in years)
            {
                yearSelector.Items.Add(year);
            }
        }
        public void SetCalendarDefaults()
        {
            DateTime currentDateTime = DateTime.Now;
            int currentMonthNumber = currentDateTime.Month;
            monthSelector.SelectedIndex = currentMonthNumber - 1;
            yearSelector.SelectedIndex = yearSelector.Items.IndexOf(currentDateTime.Year);
            fromHourSelector.SelectedIndex = 0;
            toHourSelector.SelectedIndex = 1;
            month.Content = monthSelector.Text;
            year.Content = yearSelector.Text;
        }
        private void GenerateDates(string month, string year, List<Appointment> appointments)
        {
            GetFirstDayOfTheWeekOfTheMonth();
            ChangePerceptionOfWeek();
            SetOpacityOfCells();
            SetContentOfTheDate();
            LowerOpacityOfCellsAndAmptyThemBeforeTheFirstDay();
        }
        public void ChangePerceptionOfWeek()
        {
            int sundayOnSystem = 0;
            int sundayOnCalendar = 7;

            //(Sun - Sat to Mon - Sun).
            int firstDayOfTheWeekOfTheMonth = GetFirstDayOfTheWeekOfTheMonth();
            if (firstDayOfTheWeekOfTheMonth == sundayOnSystem)
            {
                firstDayOfTheWeekOfTheMonth = sundayOnCalendar;
            }
            firstDayOfTheWeekOfTheMonth -= 1;
        }
        public void SetOpacityOfCells()
        {
            foreach (StackPanel cell in cells)
            {
                cell.Opacity = 1.0;
            }
        }
        public void SetContentOfTheDate()
        {
            List<Appointment> appointments = Appointment.GetAppointmentsList();
            DateTime dateValue = GetDateValue();

            int totalDaysOnMonth = GetTotalDaysOnMonth();
            int firstDayOfTheWeekOfTheMonth = GetFirstDayOfTheWeekOfTheMonth();
            int initialDay = 1;

            for (int dayIndex = firstDayOfTheWeekOfTheMonth; dayIndex < numbersOfDays.Count; dayIndex++)
            {
                if (initialDay <= totalDaysOnMonth)
                {
                    insertContentIntoDay(dayIndex, initialDay, appointments, dateValue);
                    initialDay += 1;
                    continue;
                }
                else
                {
                    DisableCell(dayIndex);
                }
            }
        }
        public int GetTotalDaysOnMonth()
        {
            int yearNumber = GetYearNumber();
            int monthNumber = GetMonthNumber();
            monthNumber += 1;
            int totalDaysOnMonth = DateTime.DaysInMonth(yearNumber, monthNumber);
            return totalDaysOnMonth;
        }
        public void insertContentIntoDay(int dayIndex, int initialDay, List<Appointment> appointments, DateTime dateValue)
        {
            StackPanel dayCell = cells[dayIndex];
            dayCell.Children.Clear();
            AddNumberToCell(dayIndex, initialDay, dayCell);
            foreach (var appointment in appointments)
            {
                if ((appointment.date.Year == dateValue.Year) & (appointment.date.Month == dateValue.Month) & (appointment.date.Day == initialDay))
                {
                    Label appointmentInfo = new Label();
                    appointmentInfo.Content = hours[appointment.fromHour] + " " + appointment.title;

                    dayCell.Children.Add(appointmentInfo);
                }
            }
            
        }
        public void AddNumberToCell(int dayIndex, int days, StackPanel dayCell)
        {
            Label day = numbersOfDays[dayIndex];
            day.Content = days;
            dayCell.Children.Add(day);
        }
        public void DisableCell(int dayIndex)
        {
            Label numberOfTheDay = numbersOfDays[dayIndex];
            numberOfTheDay.Content = "";
            StackPanel outOfCalendarGrid = cells[dayIndex];
            outOfCalendarGrid.Children.Clear();

            outOfCalendarGrid.Opacity = 0.3;
        }
        public DateTime GetDateValue()
        {
            int yearNumber = Convert.ToInt32(yearSelector.Text);
            int monthNumber = months.IndexOf(monthSelector.Text.ToString());
            monthNumber += 1;
            int totalDaysOnMonth = DateTime.DaysInMonth(yearNumber, monthNumber);
            int firstDayOfMonth = 1;
            DateTime dateValue = new DateTime(yearNumber, monthNumber, firstDayOfMonth);
            return dateValue;
        }
        public void LowerOpacityOfCellsAndAmptyThemBeforeTheFirstDay()
        {
            int firstDayOfTheWeekOfTheMonth = GetFirstDayOfTheWeekOfTheMonth();
            for (int dayIndex = 0; dayIndex < firstDayOfTheWeekOfTheMonth; dayIndex++)
            {

                Label numberOfDay = numbersOfDays[dayIndex];
                numberOfDay.Content = "";
                StackPanel outOfCalendarGrid = cells[dayIndex];
                outOfCalendarGrid.Children.Clear();
                outOfCalendarGrid.Opacity = 0.3;
            }
        }
        public int GetFirstDayOfTheWeekOfTheMonth()
        {
            int yearNumber = GetYearNumber();
            int monthNumber = GetMonthNumber();
            monthNumber += 1;
            int firstDayOfMonth = 1;
            DateTime dateValue = new DateTime(yearNumber, monthNumber, firstDayOfMonth);
            int firstDayOfTheWeekOfTheMonth = ((int)dateValue.DayOfWeek);
            return firstDayOfTheWeekOfTheMonth;
        }
        public int GetYearNumber()
        {
            int yearNumber = Convert.ToInt32(year.Content);
            return yearNumber;
        }
        public int GetMonthNumber()
        {
            int monthNumber = months.IndexOf(month.Content.ToString());
            return monthNumber;
        }
        private void SelectDateClick(object sender, RoutedEventArgs e)
        {
            List<Appointment> appointments = Appointment.GetAppointmentsList();
            string monthSelected = GetMonthSelected();
            string yearSelected = GetYearSelected();
            GenerateDates(monthSelected, yearSelected, appointments);

        }
        public string GetMonthSelected()
        {
            month.Content = monthSelector.Text;
            string monthSelected = month.Content.ToString();
            return monthSelected;
        }
        public string GetYearSelected()
        {
            year.Content = yearSelector.Text;
            string yearSelected = year.Content.ToString();
            return yearSelected;
        }
        public List<string> GetMonthsList()
        {
            return months;
        }
        public List<string> GetWeeksList()
        {
            return weeks;
        }
        private void CreateAppointment(object sender, RoutedEventArgs e)
        {
            List<Appointment> appointments = Appointment.GetAppointmentsList();
            Appointment newAppointment = new Appointment();
            CreateAppointmentObject();
            string monthForCreation = month.Content.ToString();
            string yearForCreation = year.Content.ToString();
            GenerateDates(monthForCreation, monthForCreation, appointments);
        }
        public void CreateAppointmentObject()
        {
            List<Appointment> appointments = Appointment.GetAppointmentsList();
            Appointment newAppointment = new Appointment();

            int fromHourIndex = hours.IndexOf(fromHourSelector.Text);
            int toHourIndex = hours.IndexOf(toHourSelector.Text);
            newAppointment.title = titleBox.Text;
            newAppointment.description = descriptionBox.Text;
            newAppointment.fromHour = fromHourIndex;
            newAppointment.toHour = toHourIndex;
            newAppointment.date = appointmentDateSelector.SelectedDate.Value;
            appointments.Add(newAppointment);

            MessageOfAppointmentCreated();

        }
        public void MessageOfAppointmentCreated()
        {
            string appointmentCreated = "Appointment Created";
            MessageBox.Show(appointmentCreated);
        }
        public void WeekClick(object sender, RoutedEventArgs e)
        {
            Week weekWindow = new Week();
            weekWindow.Show();
        }
        #endregion

    }
}
