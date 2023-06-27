using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2.CPANEL
{
    public partial class demo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           if (!IsPostBack)
            {
                // Initialize the timetable gridview with empty data
              //  BindEmptyTimetable();
            }

        }

        protected void btnGenerate_Click(object sender, EventArgs e)
        {
            List<TimetableItem> timetable = GenerateTimetable();

            // Bind the generated timetable to the gridview
          //  gvTimetable.DataSource = timetable;
          //  gvTimetable.DataBind();
        }

        private List<TimetableItem> GenerateTimetable()
        {
            throw new NotImplementedException();
        }
    }
  //  public void BindEmptyTimetable()
   // {
        //    // Bind the empty timetable to the gridview
       // gvTimetable.DataSource = new List<TimetableItem>();
        //   // gvTimetable.DataBind();
  //  }

   // private List<TimetableItem> GenerateTimetable();
    //{
       
      //  List<string> subjects = new List<string> { "Math", "Science", "English", "History", "Geography" };
      //  List<string> timeSlots = new List<string> { "8:00 - 9:00", "9:00 - 10:00", "10:00 - 11:00", "11:00 - 12:00", "12:00 - 1:00" };

    //    List<TimetableItem> timetable = new List<TimetableItem>();
    //    Random random = new Random();

    //    foreach (string timeSlot in timeSlots)
    //    {
    //        int randomIndex = random.Next(subjects.Count);
    //        string subject = subjects[randomIndex];

    //        timetable.Add(new TimetableItem { TimeSlot = timeSlot, Subject = subject });
    //    }

    //    return timetable;
    //}
}

public class TimetableItem
{
    public string TimeSlot { get; set; }
    public string Subject { get; set; }
}
