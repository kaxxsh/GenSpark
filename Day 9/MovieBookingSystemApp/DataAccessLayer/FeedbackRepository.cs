using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class FeedbackRepository
    {
        private List<Feedback> _feedbacks;

        public FeedbackRepository()
        {
            _feedbacks = new List<Feedback>();
        }

        public void AddFeedback(Feedback feedback)
        {
            _feedbacks.Add(feedback);
        }

        public List<Feedback> GetAllFeedback()
        {
            return _feedbacks;
        }
    }
}
