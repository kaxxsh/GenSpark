using DataAccessLayer;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class FeedbackManager
    {
        private FeedbackRepository _feedbackRepository;

        public FeedbackManager()
        {
            _feedbackRepository = new FeedbackRepository();
        }

        public void AddFeedback(Feedback feedback)
        {
            _feedbackRepository.AddFeedback(feedback);
        }

        public List<Feedback> GetAllFeedback()
        {
            return _feedbackRepository.GetAllFeedback();
        }
    }
}
