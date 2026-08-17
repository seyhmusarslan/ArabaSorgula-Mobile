/* [grial-metadata] id: Grial#QuizData.cs version: 1.0.4 */
using System;
using UXDivers.Grial;
namespace arabasorgula
{
	public class QuizFactData
	{
        public string Fact { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
    }

    public class QuizCategoryData
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public QuizContentData[] ListData { get; set; }
    }

    public class QuizContentData
    {
        public string Title { get; set; }
        public string Image { get; set; }
    }

    public class QuizUserProgressData
    {
        public string Icon { get; set; }
        public string Value { get; set; }
        public string Area { get; set; }
    }

    public class QuizDailyTaskData
    {
        public string Title { get; set; }
        public string Icon { get; set; }
        public double Value { get; set; }
        public double MaxValue { get; set; }
        public string BackgroundColor { get; set; }
    }

    public class QuizActivityChartData
    {
        public double MaxValue { get; set; }
        public string[] Labels { get; set; }      
        public int[] Accuracy { get; set; }
        public int[] Activity { get; set; }
    }
        

    public class QuizCompletionStatsData
    {
        public string Icon { get; set; }
        public string Value { get; set; }
        public string Label { get; set; }      

    }
}



