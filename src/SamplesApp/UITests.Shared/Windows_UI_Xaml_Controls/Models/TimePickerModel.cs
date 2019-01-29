﻿using System.Windows.Input;
using Windows.UI.Core;
using Windows.UI.Xaml.Data;
using Uno.UI.Samples.UITests.Helpers;
using System;

namespace SamplesApp.Windows_UI_Xaml_Controls.Models
{
	[Bindable]
	public class TimePickerModel : ViewModelBase
	{
		private TimeSpan _time;

		public TimePickerModel(CoreDispatcher dispatcher) : base(dispatcher)
		{
			SetToCurrentTime = CreateCommand(ExecuteSetToCurrentTime);
		}

		public TimeSpan Time
		{
			get => _time;
			set
			{
				_time = value;
				RaisePropertyChanged("Time");
			}
		}

		public ICommand SetToCurrentTime { get; }

		private void ExecuteSetToCurrentTime()
		{
			 Time = DateTime.UtcNow.TimeOfDay;
		}
	}
}