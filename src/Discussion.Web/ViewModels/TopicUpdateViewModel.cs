using Discussion.Core.Models;

namespace Discussion.Web.ViewModels
{
    public class TopicUpdateViewModel
    {
        private TopicUpdateViewModel(Topic topic)
        {
            this.Topic = topic;
        }

        public int Id => this.Topic.Id;

        public string Title => this.Topic.Title;

        public string Content => this.Topic.Content;

        public TopicType Type => this.Topic.Type;
        private Topic Topic { get; }

        public static TopicUpdateViewModel CreateFrom(Topic topic)
        {
            return new TopicUpdateViewModel(topic)
            {
            };
        }
    }
}