namespace kidLearn;

public partial class KidsLearningDetailPage : ContentPage
{
	public KidsLearningDetailPage(string categoryName)
	{
		InitializeComponent();
		DisplayLearningResult(categoryName);
	}

    private void DisplayLearningResult(string categoryName)
    {
		LearningDate learningDate = new LearningDate();
		switch (categoryName)
		{
			case "Number":
				CvKids.ItemsSource = learningDate.Numbers; break;
            case "Letters":
                CvKids.ItemsSource = learningDate.Letters; break;
            case "Shapes":
                CvKids.ItemsSource = learningDate.Shapes; break;
            case "Colors":
                CvKids.ItemsSource = learningDate.Colors; break;
            
        }
    }
}