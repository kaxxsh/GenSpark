using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    /// <summary>
    /// Repository class for managing feedback.
    /// </summary>
    public class FeedbackRepository
    {
        private List<Feedback> _feedbacks;

        /// <summary>
        /// Initializes a new instance of the FeedbackRepository class.
        /// </summary>
        public FeedbackRepository()
        {
            _feedbacks = new List<Feedback>();
        }

        /// <summary>
        /// Adds a new feedback to the repository.
        /// </summary>
        /// <param name="feedback">The feedback to add.</param>
        public void AddFeedback(Feedback feedback)
        {
            _feedbacks.Add(feedback);
        }

        /// <summary>
        /// Retrieves all feedbacks.
        /// </summary>
        /// <returns>A list of all feedbacks.</returns>
        public List<Feedback> GetAllFeedback()
        {
            return _feedbacks;
        }
    }
}
