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
				printf("����ǂݍ��ݕs�\\n");
			}

			// ���t���[�������擾����
			frame_count = cvGetCaptureProperty(capture, CV_CAP_PROP_FRAME_COUNT);
			// �^�񒆂̈ʒu�Ɉړ�����
			cvSetCaptureProperty(capture, CV_CAP_PROP_POS_FRAMES, frame_count * 0);
			// �摜�����o��
			image = cvQueryFrame(capture);
			cvSaveImage("C:\\topvar\\0.png", image);

			frame_count = cvGetCaptureProperty(capture, CV_CAP_PROP_FRAME_COUNT);
			// �^�񒆂̈ʒu�Ɉړ�����
			cvSetCaptureProperty(capture, CV_CAP_PROP_POS_FRAMES, frame_count * 0.1);
			// �摜�����o��
			image = cvQueryFrame(capture);
			cvSaveImage("C:\\topvar\\1.png", image);

			frame_count = cvGetCaptureProperty(capture, CV_CAP_PROP_FRAME_COUNT);
			// �^�񒆂̈ʒu�Ɉړ�����
			cvSetCaptureProperty(capture, CV_CAP_PROP_POS_FRAMES, frame_count * 0.2);
			// �摜�����o��
			image = cvQueryFrame(capture);
			cvSaveImage("C:\\topvar\\2.png", image);

			frame_count = cvGetCaptureProperty(capture, CV_CAP_PROP_FRAME_COUNT);
			// �^�񒆂̈ʒu�Ɉړ�����
			cvSetCaptureProperty(capture, CV_CAP_PROP_POS_FRAMES, frame_count * 0.3);
			// �摜�����o��
			image = cvQueryFrame(capture);
			cvSaveImage("C:\\topvar\\3.png", image);

			frame_count = cvGetCaptureProperty(capture, CV_CAP_PROP_FRAME_COUNT);
			// �^�񒆂̈ʒu�Ɉړ�����
			cvSetCaptureProperty(capture, CV_CAP_PROP_POS_FRAMES, frame_count * 0.4);
			// �摜�����o��
			image = cvQueryFrame(capture);
			cvSaveImage("C:\\topvar\\4.png", image);

			frame_count = cvGetCaptureProperty(capture, CV_CAP_PROP_FRAME_COUNT);
			// �^�񒆂̈ʒu�Ɉړ�����
			cvSetCaptureProperty(capture, CV_CAP_PROP_POS_FRAMES, frame_count * 0.5);
			// �摜�����o��
			image = cvQueryFrame(capture);
			cvSaveImage("C:\\topvar\\5.png", image);

			frame_count = cvGetCaptureProperty(capture, CV_CAP_PROP_FRAME_COUNT);
			// �^�񒆂̈ʒu�Ɉړ�����
			cvSetCaptureProperty(capture, CV_CAP_PROP_POS_FRAMES, frame_count * 0.6);
			// �摜�����o��
			image = cvQueryFrame(capture);
			cvSaveImage("C:\\topvar\\6.png", image);

			frame_count = cvGetCaptureProperty(capture, CV_CAP_PROP_FRAME_COUNT);
			// �^�񒆂̈ʒu�Ɉړ�����
			cvSetCaptureProperty(capture, CV_CAP_PROP_POS_FRAMES, frame_count * 0.7);
			// �摜�����o��
			image = cvQueryFrame(capture);
			cvSaveImage("C:\\topvar\\7.png", image);

			frame_count = cvGetCaptureProperty(capture, CV_CAP_PROP_FRAME_COUNT);
			// �^�񒆂̈ʒu�Ɉړ�����
			cvSetCaptureProperty(capture, CV_CAP_PROP_POS_FRAMES, frame_count * 0.8);
			// �摜�����o��
			image = cvQueryFrame(capture);
			cvSaveImage("C:\\topvar\\8.png", image);

			frame_count = cvGetCaptureProperty(capture, CV_CAP_PROP_FRAME_COUNT);
			// �^�񒆂̈ʒu�Ɉړ�����
			cvSetCaptureProperty(capture, CV_CAP_PROP_POS_FRAMES, frame_count * 0.9);
			// �摜�����o��
			image = cvQueryFrame(capture);
			cvSaveImage("C:\\topvar\\9.png", image);

			// �������J��
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
				printf("����ǂݍ��ݕs�\\n");
			}

			// ���t���[�������擾����
			frame_count = cvGetCaptureProperty(capture, CV_CAP_PROP_FRAME_COUNT);
			// �^�񒆂̈ʒu�Ɉړ�����
			cvSetCaptureProperty(capture, CV_CAP_PROP_POS_FRAMES, frame_count * 0);
			// �摜�����o��
			image = cvQueryFrame(capture);
			cvSaveImage("C:\\orgvar\\0.png", image);

			frame_count = cvGetCaptureProperty(capture, CV_CAP_PROP_FRAME_COUNT);
			// �^�񒆂̈ʒu�Ɉړ�����
			cvSetCaptureProperty(capture, CV_CAP_PROP_POS_FRAMES, frame_count * 0.1);
			// �摜�����o��
			image = cvQueryFrame(capture);
			cvSaveImage("C:\\orgvar\\1.png", image);

			frame_count = cvGetCaptureProperty(capture, CV_CAP_PROP_FRAME_COUNT);
			// �^�񒆂̈ʒu�Ɉړ�����
			cvSetCaptureProperty(capture, CV_CAP_PROP_POS_FRAMES, frame_count * 0.2);
			// �摜�����o��
			image = cvQueryFrame(capture);
			cvSaveImage("C:\\orgvar\\2.png", image);

			frame_count = cvGetCaptureProperty(capture, CV_CAP_PROP_FRAME_COUNT);
			// �^�񒆂̈ʒu�Ɉړ�����
			cvSetCaptureProperty(capture, CV_CAP_PROP_POS_FRAMES, frame_count * 0.3);
			// �摜�����o��
			image = cvQueryFrame(capture);
			cvSaveImage("C:\\orgvar\\3.png", image);

			frame_count = cvGetCaptureProperty(capture, CV_CAP_PROP_FRAME_COUNT);
			// �^�񒆂̈ʒu�Ɉړ�����
			cvSetCaptureProperty(capture, CV_CAP_PROP_POS_FRAMES, frame_count * 0.4);
			// �摜�����o��
			image = cvQueryFrame(capture);
			cvSaveImage("C:\\orgvar\\4.png", image);

			frame_count = cvGetCaptureProperty(capture, CV_CAP_PROP_FRAME_COUNT);
			// �^�񒆂̈ʒu�Ɉړ�����
			cvSetCaptureProperty(capture, CV_CAP_PROP_POS_FRAMES, frame_count * 0.5);
			// �摜�����o��
			image = cvQueryFrame(capture);
			cvSaveImage("C:\\orgvar\\5.png", image);

			frame_count = cvGetCaptureProperty(capture, CV_CAP_PROP_FRAME_COUNT);
			// �^�񒆂̈ʒu�Ɉړ�����
			cvSetCaptureProperty(capture, CV_CAP_PROP_POS_FRAMES, frame_count * 0.6);
			// �摜�����o��
			image = cvQueryFrame(capture);
			cvSaveImage("C:\\orgvar\\6.png", image);

			frame_count = cvGetCaptureProperty(capture, CV_CAP_PROP_FRAME_COUNT);
			// �^�񒆂̈ʒu�Ɉړ�����
			cvSetCaptureProperty(capture, CV_CAP_PROP_POS_FRAMES, frame_count * 0.7);
			// �摜�����o��
			image = cvQueryFrame(capture);
			cvSaveImage("C:\\orgvar\\7.png", image);

			frame_count = cvGetCaptureProperty(capture, CV_CAP_PROP_FRAME_COUNT);
			// �^�񒆂̈ʒu�Ɉړ�����
			cvSetCaptureProperty(capture, CV_CAP_PROP_POS_FRAMES, frame_count * 0.8);
			// �摜�����o��
			image = cvQueryFrame(capture);
			cvSaveImage("C:\\orgvar\\8.png", image);

			frame_count = cvGetCaptureProperty(capture, CV_CAP_PROP_FRAME_COUNT);
			// �^�񒆂̈ʒu�Ɉړ�����
			cvSetCaptureProperty(capture, CV_CAP_PROP_POS_FRAMES, frame_count * 0.9);
			// �摜�����o��
			image = cvQueryFrame(capture);
			cvSaveImage("C:\\orgvar\\9.png", image);

			// �������J��
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
				printf("����ǂݍ��ݕs�\\n");
			}

			// ���t���[�������擾����
			frame_count = cvGetCaptureProperty(capture, CV_CAP_PROP_FRAME_COUNT);
			// �^�񒆂̈ʒu�Ɉړ�����
			cvSetCaptureProperty(capture, CV_CAP_PROP_POS_FRAMES, frame_count * 0);
			// �摜�����o��
			image = cvQueryFrame(capture);
			cvSaveImage("C:\\parvar\\0.png", image);

			frame_count = cvGetCaptureProperty(capture, CV_CAP_PROP_FRAME_COUNT);
			// �^�񒆂̈ʒu�Ɉړ�����
			cvSetCaptureProperty(capture, CV_CAP_PROP_POS_FRAMES, frame_count * 0.1);
			// �摜�����o��
			image = cvQueryFrame(capture);
			cvSaveImage("C:\\parvar\\1.png", image);

			frame_count = cvGetCaptureProperty(capture, CV_CAP_PROP_FRAME_COUNT);
			// �^�񒆂̈ʒu�Ɉړ�����
			cvSetCaptureProperty(capture, CV_CAP_PROP_POS_FRAMES, frame_count * 0.2);
			// �摜�����o��
			image = cvQueryFrame(capture);
			cvSaveImage("C:\\parvar\\2.png", image);

			frame_count = cvGetCaptureProperty(capture, CV_CAP_PROP_FRAME_COUNT);
			// �^�񒆂̈ʒu�Ɉړ�����
			cvSetCaptureProperty(capture, CV_CAP_PROP_POS_FRAMES, frame_count * 0.3);
			// �摜�����o��
			image = cvQueryFrame(capture);
			cvSaveImage("C:\\parvar\\3.png", image);

			frame_count = cvGetCaptureProperty(capture, CV_CAP_PROP_FRAME_COUNT);
			// �^�񒆂̈ʒu�Ɉړ�����
			cvSetCaptureProperty(capture, CV_CAP_PROP_POS_FRAMES, frame_count * 0.4);
			// �摜�����o��
			image = cvQueryFrame(capture);
			cvSaveImage("C:\\parvar\\4.png", image);

			frame_count = cvGetCaptureProperty(capture, CV_CAP_PROP_FRAME_COUNT);
			// �^�񒆂̈ʒu�Ɉړ�����
			cvSetCaptureProperty(capture, CV_CAP_PROP_POS_FRAMES, frame_count * 0.5);
			// �摜�����o��
			image = cvQueryFrame(capture);
			cvSaveImage("C:\\parvar\\5.png", image);

			frame_count = cvGetCaptureProperty(capture, CV_CAP_PROP_FRAME_COUNT);
			// �^�񒆂̈ʒu�Ɉړ�����
			cvSetCaptureProperty(capture, CV_CAP_PROP_POS_FRAMES, frame_count * 0.6);
			// �摜�����o��
			image = cvQueryFrame(capture);
			cvSaveImage("C:\\parvar\\6.png", image);

			frame_count = cvGetCaptureProperty(capture, CV_CAP_PROP_FRAME_COUNT);
			// �^�񒆂̈ʒu�Ɉړ�����
			cvSetCaptureProperty(capture, CV_CAP_PROP_POS_FRAMES, frame_count * 0.7);
			// �摜�����o��
			image = cvQueryFrame(capture);
			cvSaveImage("C:\\parvar\\7.png", image);

			frame_count = cvGetCaptureProperty(capture, CV_CAP_PROP_FRAME_COUNT);
			// �^�񒆂̈ʒu�Ɉړ�����
			cvSetCaptureProperty(capture, CV_CAP_PROP_POS_FRAMES, frame_count * 0.8);
			// �摜�����o��
			image = cvQueryFrame(capture);
			cvSaveImage("C:\\parvar\\8.png", image);

			frame_count = cvGetCaptureProperty(capture, CV_CAP_PROP_FRAME_COUNT);
			// �^�񒆂̈ʒu�Ɉړ�����
			cvSetCaptureProperty(capture, CV_CAP_PROP_POS_FRAMES, frame_count * 0.9);
			// �摜�����o��
			image = cvQueryFrame(capture);
			cvSaveImage("C:\\parvar\\9.png", image);

			// �������J��
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
				printf("����ǂݍ��ݕs�\\n");
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
				printf("����ǂݍ��ݕs�\\n");
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
				printf("����ǂݍ��ݕs�\\n");
			}

			frame_count = cvGetCaptureProperty(capture, CV_CAP_PROP_FRAME_COUNT);
			cvSetCaptureProperty(capture, CV_CAP_PROP_POS_FRAMES, i * 29);
			image = cvQueryFrame(capture);
			cvSaveImage("C:\\thum\\thum.png", image);

		}
	};
}
