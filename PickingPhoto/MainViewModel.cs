using System.ComponentModel;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using Xamarin.Forms;

namespace PickingPhoto
{
    public class MainViewModel : INotifyPropertyChanged
    {
		#region Events
		public event PropertyChangedEventHandler PropertyChanged;
		#endregion

		#region Attributes
		private ImageSource imageSource;
		#endregion

		#region Properties
		public ImageSource ImageSource
		{
			set
			{
				if (imageSource != value)
				{
					imageSource = value;
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ImageSource"));
				}
			}
			get
			{
				return imageSource;
			}
		}
		#endregion

		#region Constructors
		public MainViewModel()
        {
        }
        #endregion

        #region Commands
        public ICommand PickPhotoCommand
        {
            get { return new RelayCommand(PickPhoto); }
        }

        private async void PickPhoto()
        {
			var stream = await DependencyService.Get<IPicturePicker>().GetImageStreamAsync();

			if (stream != null)
			{
				var Image = new Image
				{
					Source = ImageSource.FromStream(() => stream),
				};

                ImageSource = Image.Source;
			}        
        }
        #endregion
    }
}
