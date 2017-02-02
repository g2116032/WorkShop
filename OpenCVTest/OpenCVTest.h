// OpenCVTest.h

#pragma once
#include <opencv2/opencv.hpp>

using namespace System;

namespace OpenCVTest {

	public ref class Class1
	{
	public:
		static void Top()
		{
			char *filename = "C:\\top.mp4";
			IplImage *image;
			CvCapture *capture;
			double frame_count;

			capture = cvCaptureFromAVI(filename);
			if (capture == NULL)
			{
				printf("動画読み込み不能\n");
			}

			// 総フレーム数を取得する
			frame_count = cvGetCaptureProperty(capture, CV_CAP_PROP_FRAME_COUNT);
			// 真ん中の位置に移動する
			cvSetCaptureProperty(capture, CV_CAP_PROP_POS_FRAMES, frame_count * 0);
			// 画像を取り出す
			image = cvQueryFrame(capture);
			cvSaveImage("C:\\topvar\\0.png", image);

			frame_count = cvGetCaptureProperty(capture, CV_CAP_PROP_FRAME_COUNT);
			// 真ん中の位置に移動する
			cvSetCaptureProperty(capture, CV_CAP_PROP_POS_FRAMES, frame_count * 0.1);
			// 画像を取り出す
			image = cvQueryFrame(capture);
			cvSaveImage("C:\\topvar\\1.png", image);

			frame_count = cvGetCaptureProperty(capture, CV_CAP_PROP_FRAME_COUNT);
			// 真ん中の位置に移動する
			cvSetCaptureProperty(capture, CV_CAP_PROP_POS_FRAMES, frame_count * 0.2);
			// 画像を取り出す
			image = cvQueryFrame(capture);
			cvSaveImage("C:\\topvar\\2.png", image);

			frame_count = cvGetCaptureProperty(capture, CV_CAP_PROP_FRAME_COUNT);
			// 真ん中の位置に移動する
			cvSetCaptureProperty(capture, CV_CAP_PROP_POS_FRAMES, frame_count * 0.3);
			// 画像を取り出す
			image = cvQueryFrame(capture);
			cvSaveImage("C:\\topvar\\3.png", image);

			frame_count = cvGetCaptureProperty(capture, CV_CAP_PROP_FRAME_COUNT);
			// 真ん中の位置に移動する
			cvSetCaptureProperty(capture, CV_CAP_PROP_POS_FRAMES, frame_count * 0.4);
			// 画像を取り出す
			image = cvQueryFrame(capture);
			cvSaveImage("C:\\topvar\\4.png", image);

			frame_count = cvGetCaptureProperty(capture, CV_CAP_PROP_FRAME_COUNT);
			// 真ん中の位置に移動する
			cvSetCaptureProperty(capture, CV_CAP_PROP_POS_FRAMES, frame_count * 0.5);
			// 画像を取り出す
			image = cvQueryFrame(capture);
			cvSaveImage("C:\\topvar\\5.png", image);

			frame_count = cvGetCaptureProperty(capture, CV_CAP_PROP_FRAME_COUNT);
			// 真ん中の位置に移動する
			cvSetCaptureProperty(capture, CV_CAP_PROP_POS_FRAMES, frame_count * 0.6);
			// 画像を取り出す
			image = cvQueryFrame(capture);
			cvSaveImage("C:\\topvar\\6.png", image);

			frame_count = cvGetCaptureProperty(capture, CV_CAP_PROP_FRAME_COUNT);
			// 真ん中の位置に移動する
			cvSetCaptureProperty(capture, CV_CAP_PROP_POS_FRAMES, frame_count * 0.7);
			// 画像を取り出す
			image = cvQueryFrame(capture);
			cvSaveImage("C:\\topvar\\7.png", image);

			frame_count = cvGetCaptureProperty(capture, CV_CAP_PROP_FRAME_COUNT);
			// 真ん中の位置に移動する
			cvSetCaptureProperty(capture, CV_CAP_PROP_POS_FRAMES, frame_count * 0.8);
			// 画像を取り出す
			image = cvQueryFrame(capture);
			cvSaveImage("C:\\topvar\\8.png", image);

			frame_count = cvGetCaptureProperty(capture, CV_CAP_PROP_FRAME_COUNT);
			// 真ん中の位置に移動する
			cvSetCaptureProperty(capture, CV_CAP_PROP_POS_FRAMES, frame_count * 0.9);
			// 画像を取り出す
			image = cvQueryFrame(capture);
			cvSaveImage("C:\\topvar\\9.png", image);

			// メモリ開放
			cvReleaseCapture(&capture);
		}

		static void Org()
		{
			char *filename = "C:\\org.mp4";
			IplImage *image;
			CvCapture *capture;
			double frame_count;

			capture = cvCaptureFromAVI(filename);
			if (capture == NULL)
			{
				printf("動画読み込み不能\n");
			}

			// 総フレーム数を取得する
			frame_count = cvGetCaptureProperty(capture, CV_CAP_PROP_FRAME_COUNT);
			// 真ん中の位置に移動する
			cvSetCaptureProperty(capture, CV_CAP_PROP_POS_FRAMES, frame_count * 0);
			// 画像を取り出す
			image = cvQueryFrame(capture);
			cvSaveImage("C:\\orgvar\\0.png", image);

			frame_count = cvGetCaptureProperty(capture, CV_CAP_PROP_FRAME_COUNT);
			// 真ん中の位置に移動する
			cvSetCaptureProperty(capture, CV_CAP_PROP_POS_FRAMES, frame_count * 0.1);
			// 画像を取り出す
			image = cvQueryFrame(capture);
			cvSaveImage("C:\\orgvar\\1.png", image);

			frame_count = cvGetCaptureProperty(capture, CV_CAP_PROP_FRAME_COUNT);
			// 真ん中の位置に移動する
			cvSetCaptureProperty(capture, CV_CAP_PROP_POS_FRAMES, frame_count * 0.2);
			// 画像を取り出す
			image = cvQueryFrame(capture);
			cvSaveImage("C:\\orgvar\\2.png", image);

			frame_count = cvGetCaptureProperty(capture, CV_CAP_PROP_FRAME_COUNT);
			// 真ん中の位置に移動する
			cvSetCaptureProperty(capture, CV_CAP_PROP_POS_FRAMES, frame_count * 0.3);
			// 画像を取り出す
			image = cvQueryFrame(capture);
			cvSaveImage("C:\\orgvar\\3.png", image);

			frame_count = cvGetCaptureProperty(capture, CV_CAP_PROP_FRAME_COUNT);
			// 真ん中の位置に移動する
			cvSetCaptureProperty(capture, CV_CAP_PROP_POS_FRAMES, frame_count * 0.4);
			// 画像を取り出す
			image = cvQueryFrame(capture);
			cvSaveImage("C:\\orgvar\\4.png", image);

			frame_count = cvGetCaptureProperty(capture, CV_CAP_PROP_FRAME_COUNT);
			// 真ん中の位置に移動する
			cvSetCaptureProperty(capture, CV_CAP_PROP_POS_FRAMES, frame_count * 0.5);
			// 画像を取り出す
			image = cvQueryFrame(capture);
			cvSaveImage("C:\\orgvar\\5.png", image);

			frame_count = cvGetCaptureProperty(capture, CV_CAP_PROP_FRAME_COUNT);
			// 真ん中の位置に移動する
			cvSetCaptureProperty(capture, CV_CAP_PROP_POS_FRAMES, frame_count * 0.6);
			// 画像を取り出す
			image = cvQueryFrame(capture);
			cvSaveImage("C:\\orgvar\\6.png", image);

			frame_count = cvGetCaptureProperty(capture, CV_CAP_PROP_FRAME_COUNT);
			// 真ん中の位置に移動する
			cvSetCaptureProperty(capture, CV_CAP_PROP_POS_FRAMES, frame_count * 0.7);
			// 画像を取り出す
			image = cvQueryFrame(capture);
			cvSaveImage("C:\\orgvar\\7.png", image);

			frame_count = cvGetCaptureProperty(capture, CV_CAP_PROP_FRAME_COUNT);
			// 真ん中の位置に移動する
			cvSetCaptureProperty(capture, CV_CAP_PROP_POS_FRAMES, frame_count * 0.8);
			// 画像を取り出す
			image = cvQueryFrame(capture);
			cvSaveImage("C:\\orgvar\\8.png", image);

			frame_count = cvGetCaptureProperty(capture, CV_CAP_PROP_FRAME_COUNT);
			// 真ん中の位置に移動する
			cvSetCaptureProperty(capture, CV_CAP_PROP_POS_FRAMES, frame_count * 0.9);
			// 画像を取り出す
			image = cvQueryFrame(capture);
			cvSaveImage("C:\\orgvar\\9.png", image);

			// メモリ開放
			cvReleaseCapture(&capture);
		}

		static void Par()
		{
			char *filename = "C:\\par.mp4";
			IplImage *image;
			CvCapture *capture;
			double frame_count;

			capture = cvCaptureFromAVI(filename);
			if (capture == NULL)
			{
				printf("動画読み込み不能\n");
			}

			// 総フレーム数を取得する
			frame_count = cvGetCaptureProperty(capture, CV_CAP_PROP_FRAME_COUNT);
			// 真ん中の位置に移動する
			cvSetCaptureProperty(capture, CV_CAP_PROP_POS_FRAMES, frame_count * 0);
			// 画像を取り出す
			image = cvQueryFrame(capture);
			cvSaveImage("C:\\parvar\\0.png", image);

			frame_count = cvGetCaptureProperty(capture, CV_CAP_PROP_FRAME_COUNT);
			// 真ん中の位置に移動する
			cvSetCaptureProperty(capture, CV_CAP_PROP_POS_FRAMES, frame_count * 0.1);
			// 画像を取り出す
			image = cvQueryFrame(capture);
			cvSaveImage("C:\\parvar\\1.png", image);

			frame_count = cvGetCaptureProperty(capture, CV_CAP_PROP_FRAME_COUNT);
			// 真ん中の位置に移動する
			cvSetCaptureProperty(capture, CV_CAP_PROP_POS_FRAMES, frame_count * 0.2);
			// 画像を取り出す
			image = cvQueryFrame(capture);
			cvSaveImage("C:\\parvar\\2.png", image);

			frame_count = cvGetCaptureProperty(capture, CV_CAP_PROP_FRAME_COUNT);
			// 真ん中の位置に移動する
			cvSetCaptureProperty(capture, CV_CAP_PROP_POS_FRAMES, frame_count * 0.3);
			// 画像を取り出す
			image = cvQueryFrame(capture);
			cvSaveImage("C:\\parvar\\3.png", image);

			frame_count = cvGetCaptureProperty(capture, CV_CAP_PROP_FRAME_COUNT);
			// 真ん中の位置に移動する
			cvSetCaptureProperty(capture, CV_CAP_PROP_POS_FRAMES, frame_count * 0.4);
			// 画像を取り出す
			image = cvQueryFrame(capture);
			cvSaveImage("C:\\parvar\\4.png", image);

			frame_count = cvGetCaptureProperty(capture, CV_CAP_PROP_FRAME_COUNT);
			// 真ん中の位置に移動する
			cvSetCaptureProperty(capture, CV_CAP_PROP_POS_FRAMES, frame_count * 0.5);
			// 画像を取り出す
			image = cvQueryFrame(capture);
			cvSaveImage("C:\\parvar\\5.png", image);

			frame_count = cvGetCaptureProperty(capture, CV_CAP_PROP_FRAME_COUNT);
			// 真ん中の位置に移動する
			cvSetCaptureProperty(capture, CV_CAP_PROP_POS_FRAMES, frame_count * 0.6);
			// 画像を取り出す
			image = cvQueryFrame(capture);
			cvSaveImage("C:\\parvar\\6.png", image);

			frame_count = cvGetCaptureProperty(capture, CV_CAP_PROP_FRAME_COUNT);
			// 真ん中の位置に移動する
			cvSetCaptureProperty(capture, CV_CAP_PROP_POS_FRAMES, frame_count * 0.7);
			// 画像を取り出す
			image = cvQueryFrame(capture);
			cvSaveImage("C:\\parvar\\7.png", image);

			frame_count = cvGetCaptureProperty(capture, CV_CAP_PROP_FRAME_COUNT);
			// 真ん中の位置に移動する
			cvSetCaptureProperty(capture, CV_CAP_PROP_POS_FRAMES, frame_count * 0.8);
			// 画像を取り出す
			image = cvQueryFrame(capture);
			cvSaveImage("C:\\parvar\\8.png", image);

			frame_count = cvGetCaptureProperty(capture, CV_CAP_PROP_FRAME_COUNT);
			// 真ん中の位置に移動する
			cvSetCaptureProperty(capture, CV_CAP_PROP_POS_FRAMES, frame_count * 0.9);
			// 画像を取り出す
			image = cvQueryFrame(capture);
			cvSaveImage("C:\\parvar\\9.png", image);

			// メモリ開放
			cvReleaseCapture(&capture);
		}

		static void thumtop(int i)
		{
			char *filename = "C:\\top.mp4";
			IplImage *image;
			CvCapture *capture;
			double frame_count;

			capture = cvCaptureFromAVI(filename);
			if (capture == NULL)
			{
				printf("動画読み込み不能\n");
			}

			frame_count = cvGetCaptureProperty(capture, CV_CAP_PROP_FRAME_COUNT);
			cvSetCaptureProperty(capture, CV_CAP_PROP_POS_FRAMES, i * 29);
			image = cvQueryFrame(capture);
			cvSaveImage("C:\\thum\\thum.png", image);
			
		}

		static void thumorg(int i)
		{
			char *filename = "C:\\org.mp4";
			IplImage *image;
			CvCapture *capture;
			double frame_count;

			capture = cvCaptureFromAVI(filename);
			if (capture == NULL)
			{
				printf("動画読み込み不能\n");
			}

			frame_count = cvGetCaptureProperty(capture, CV_CAP_PROP_FRAME_COUNT);
			cvSetCaptureProperty(capture, CV_CAP_PROP_POS_FRAMES, i * 29);
			image = cvQueryFrame(capture);
			cvSaveImage("C:\\thum\\thum.png", image);

		}

		static void thumpar(int i)
		{
			char *filename = "C:\\par.mp4";
			IplImage *image;
			CvCapture *capture;
			double frame_count;

			capture = cvCaptureFromAVI(filename);
			if (capture == NULL)
			{
				printf("動画読み込み不能\n");
			}

			frame_count = cvGetCaptureProperty(capture, CV_CAP_PROP_FRAME_COUNT);
			cvSetCaptureProperty(capture, CV_CAP_PROP_POS_FRAMES, i * 29);
			image = cvQueryFrame(capture);
			cvSaveImage("C:\\thum\\thum.png", image);

		}
	};
}
