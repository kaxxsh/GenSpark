using DataAccessLayer;
using Models;
using System;
using System.Collections.Generic;

namespace BusinessLogicLayer
{
    /// <summary>
    /// Manages feedback-related operations by interacting with the FeedbackRepository.
    /// </summary>
    public class FeedbackManager
    {
        private FeedbackRepository _feedbackRepository;

        /// <summary>
        /// Initializes a new instance of the FeedbackManager class.
        /// </summary>
        public FeedbackManager()
        {
            _feedbackRepository = new FeedbackRepository();
        }

        /// <summary>
        /// Adds new feedback.
        /// </summary>
        /// <param name="feedback">The feedback to add.</param>
        public void AddFeedback(Feedback feedback)
        {
            _feedbackRepository.AddFeedback(feedback);
        }

        /// <summary>
        /// Retrieves all feedback.
        /// </summary>
        /// <returns>A list of all feedback.</returns>
        public List<Feedback> GetAllFeedback()
        {
            return _feedbackRepository.GetAllFeedback();
        }
    }
}
