﻿using GalaSoft.MvvmLight.CommandWpf;
using YoutubeExplode.Models;
using YoutubeExplode.Models.ClosedCaptions;
using YoutubeExplode.Models.MediaStreams;

namespace DemoWpf.ViewModels
{
    public interface IMainViewModel
    {
        bool IsBusy { get; }
        string Query { get; set; }

        Video Video { get; }
        bool IsVideoAvailable { get; }

        double Progress { get; }
        bool IsProgressIndeterminate { get; }

        RelayCommand GetVideoCommand { get; }
        RelayCommand<MediaStreamInfo> DownloadMediaStreamCommand { get; }
        RelayCommand<ClosedCaptionTrackInfo> DownloadClosedCaptionTrackCommand { get; }
    }
}
