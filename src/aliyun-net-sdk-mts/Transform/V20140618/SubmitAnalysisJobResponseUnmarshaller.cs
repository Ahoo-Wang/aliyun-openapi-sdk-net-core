/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Mts.Model.V20140618;
using System.Collections.Generic;

namespace Aliyun.Acs.Mts.Transform.V20140618
{
    public class SubmitAnalysisJobResponseUnmarshaller
    {
        public static SubmitAnalysisJobResponse Unmarshall(UnmarshallerContext context)
        {
            SubmitAnalysisJobResponse submitAnalysisJobResponse = new SubmitAnalysisJobResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("SubmitAnalysisJob.RequestId")
            };
            SubmitAnalysisJobResponse.AnalysisJob_ analysisJob = new SubmitAnalysisJobResponse.AnalysisJob_()
            {
                Id = context.StringValue("SubmitAnalysisJob.AnalysisJob.Id"),
                UserData = context.StringValue("SubmitAnalysisJob.AnalysisJob.UserData"),
                State = context.StringValue("SubmitAnalysisJob.AnalysisJob.State"),
                Code = context.StringValue("SubmitAnalysisJob.AnalysisJob.Code"),
                Message = context.StringValue("SubmitAnalysisJob.AnalysisJob.Message"),
                Percent = context.LongValue("SubmitAnalysisJob.AnalysisJob.Percent"),
                CreationTime = context.StringValue("SubmitAnalysisJob.AnalysisJob.CreationTime"),
                PipelineId = context.StringValue("SubmitAnalysisJob.AnalysisJob.PipelineId"),
                Priority = context.StringValue("SubmitAnalysisJob.AnalysisJob.Priority")
            };
            SubmitAnalysisJobResponse.AnalysisJob_.InputFile_ inputFile = new SubmitAnalysisJobResponse.AnalysisJob_.InputFile_()
            {
                Bucket = context.StringValue("SubmitAnalysisJob.AnalysisJob.InputFile.Bucket"),
                Location = context.StringValue("SubmitAnalysisJob.AnalysisJob.InputFile.Location"),
                Object = context.StringValue("SubmitAnalysisJob.AnalysisJob.InputFile.Object")
            };
            analysisJob.InputFile = inputFile;

			SubmitAnalysisJobResponse.AnalysisJob_.AnalysisConfig_ analysisConfig = new SubmitAnalysisJobResponse.AnalysisJob_.AnalysisConfig_();

            SubmitAnalysisJobResponse.AnalysisJob_.AnalysisConfig_.QualityControl_ qualityControl = new SubmitAnalysisJobResponse.AnalysisJob_.AnalysisConfig_.QualityControl_()
            {
                RateQuality = context.StringValue("SubmitAnalysisJob.AnalysisJob.AnalysisConfig.QualityControl.RateQuality"),
                MethodStreaming = context.StringValue("SubmitAnalysisJob.AnalysisJob.AnalysisConfig.QualityControl.MethodStreaming")
            };
            analysisConfig.QualityControl = qualityControl;

            SubmitAnalysisJobResponse.AnalysisJob_.AnalysisConfig_.PropertiesControl_ propertiesControl = new SubmitAnalysisJobResponse.AnalysisJob_.AnalysisConfig_.PropertiesControl_()
            {
                Deinterlace = context.StringValue("SubmitAnalysisJob.AnalysisJob.AnalysisConfig.PropertiesControl.Deinterlace")
            };
            SubmitAnalysisJobResponse.AnalysisJob_.AnalysisConfig_.PropertiesControl_.Crop_ crop = new SubmitAnalysisJobResponse.AnalysisJob_.AnalysisConfig_.PropertiesControl_.Crop_()
            {
                Mode = context.StringValue("SubmitAnalysisJob.AnalysisJob.AnalysisConfig.PropertiesControl.Crop.Mode"),
                Width = context.StringValue("SubmitAnalysisJob.AnalysisJob.AnalysisConfig.PropertiesControl.Crop.Width"),
                Height = context.StringValue("SubmitAnalysisJob.AnalysisJob.AnalysisConfig.PropertiesControl.Crop.Height"),
                Top = context.StringValue("SubmitAnalysisJob.AnalysisJob.AnalysisConfig.PropertiesControl.Crop.Top"),
                Left = context.StringValue("SubmitAnalysisJob.AnalysisJob.AnalysisConfig.PropertiesControl.Crop.Left")
            };
            propertiesControl.Crop = crop;
			analysisConfig.PropertiesControl = propertiesControl;
			analysisJob.AnalysisConfig = analysisConfig;

            SubmitAnalysisJobResponse.AnalysisJob_.MnsMessageResult_ mNsMessageResult = new SubmitAnalysisJobResponse.AnalysisJob_.MnsMessageResult_()
            {
                MessageId = context.StringValue("SubmitAnalysisJob.AnalysisJob.MNSMessageResult.MessageId"),
                ErrorMessage = context.StringValue("SubmitAnalysisJob.AnalysisJob.MNSMessageResult.ErrorMessage"),
                ErrorCode = context.StringValue("SubmitAnalysisJob.AnalysisJob.MNSMessageResult.ErrorCode")
            };
            analysisJob.MnsMessageResult = mNsMessageResult;

			List<SubmitAnalysisJobResponse.AnalysisJob_.Template> templateList = new List<SubmitAnalysisJobResponse.AnalysisJob_.Template>();
			for (int i = 0; i < context.Length("SubmitAnalysisJob.AnalysisJob.TemplateList.Length"); i++) {
                SubmitAnalysisJobResponse.AnalysisJob_.Template template = new SubmitAnalysisJobResponse.AnalysisJob_.Template()
                {
                    Id = context.StringValue($"SubmitAnalysisJob.AnalysisJob.TemplateList[{i}].Id"),
                    Name = context.StringValue($"SubmitAnalysisJob.AnalysisJob.TemplateList[{i}].Name"),
                    State = context.StringValue($"SubmitAnalysisJob.AnalysisJob.TemplateList[{i}].State")
                };
                SubmitAnalysisJobResponse.AnalysisJob_.Template.Container_ container = new SubmitAnalysisJobResponse.AnalysisJob_.Template.Container_()
                {
                    Format = context.StringValue($"SubmitAnalysisJob.AnalysisJob.TemplateList[{i}].Container.Format")
                };
                template.Container = container;

                SubmitAnalysisJobResponse.AnalysisJob_.Template.Video_ video = new SubmitAnalysisJobResponse.AnalysisJob_.Template.Video_()
                {
                    Codec = context.StringValue($"SubmitAnalysisJob.AnalysisJob.TemplateList[{i}].Video.Codec"),
                    Profile = context.StringValue($"SubmitAnalysisJob.AnalysisJob.TemplateList[{i}].Video.Profile"),
                    Bitrate = context.StringValue($"SubmitAnalysisJob.AnalysisJob.TemplateList[{i}].Video.Bitrate"),
                    Crf = context.StringValue($"SubmitAnalysisJob.AnalysisJob.TemplateList[{i}].Video.Crf"),
                    Width = context.StringValue($"SubmitAnalysisJob.AnalysisJob.TemplateList[{i}].Video.Width"),
                    Height = context.StringValue($"SubmitAnalysisJob.AnalysisJob.TemplateList[{i}].Video.Height"),
                    Fps = context.StringValue($"SubmitAnalysisJob.AnalysisJob.TemplateList[{i}].Video.Fps"),
                    Gop = context.StringValue($"SubmitAnalysisJob.AnalysisJob.TemplateList[{i}].Video.Gop"),
                    Preset = context.StringValue($"SubmitAnalysisJob.AnalysisJob.TemplateList[{i}].Video.Preset"),
                    ScanMode = context.StringValue($"SubmitAnalysisJob.AnalysisJob.TemplateList[{i}].Video.ScanMode"),
                    Bufsize = context.StringValue($"SubmitAnalysisJob.AnalysisJob.TemplateList[{i}].Video.Bufsize"),
                    Maxrate = context.StringValue($"SubmitAnalysisJob.AnalysisJob.TemplateList[{i}].Video.Maxrate"),
                    PixFmt = context.StringValue($"SubmitAnalysisJob.AnalysisJob.TemplateList[{i}].Video.PixFmt"),
                    Degrain = context.StringValue($"SubmitAnalysisJob.AnalysisJob.TemplateList[{i}].Video.Degrain"),
                    Qscale = context.StringValue($"SubmitAnalysisJob.AnalysisJob.TemplateList[{i}].Video.Qscale")
                };
                SubmitAnalysisJobResponse.AnalysisJob_.Template.Video_.BitrateBnd_ bitrateBnd = new SubmitAnalysisJobResponse.AnalysisJob_.Template.Video_.BitrateBnd_()
                {
                    Max = context.StringValue($"SubmitAnalysisJob.AnalysisJob.TemplateList[{i}].Video.BitrateBnd.Max"),
                    Min = context.StringValue($"SubmitAnalysisJob.AnalysisJob.TemplateList[{i}].Video.BitrateBnd.Min")
                };
                video.BitrateBnd = bitrateBnd;
				template.Video = video;

                SubmitAnalysisJobResponse.AnalysisJob_.Template.Audio_ audio = new SubmitAnalysisJobResponse.AnalysisJob_.Template.Audio_()
                {
                    Codec = context.StringValue($"SubmitAnalysisJob.AnalysisJob.TemplateList[{i}].Audio.Codec"),
                    Profile = context.StringValue($"SubmitAnalysisJob.AnalysisJob.TemplateList[{i}].Audio.Profile"),
                    Samplerate = context.StringValue($"SubmitAnalysisJob.AnalysisJob.TemplateList[{i}].Audio.Samplerate"),
                    Bitrate = context.StringValue($"SubmitAnalysisJob.AnalysisJob.TemplateList[{i}].Audio.Bitrate"),
                    Channels = context.StringValue($"SubmitAnalysisJob.AnalysisJob.TemplateList[{i}].Audio.Channels"),
                    Qscale = context.StringValue($"SubmitAnalysisJob.AnalysisJob.TemplateList[{i}].Audio.Qscale")
                };
                template.Audio = audio;

                SubmitAnalysisJobResponse.AnalysisJob_.Template.TransConfig_ transConfig = new SubmitAnalysisJobResponse.AnalysisJob_.Template.TransConfig_()
                {
                    TransMode = context.StringValue($"SubmitAnalysisJob.AnalysisJob.TemplateList[{i}].TransConfig.TransMode")
                };
                template.TransConfig = transConfig;

				SubmitAnalysisJobResponse.AnalysisJob_.Template.MuxConfig_ muxConfig = new SubmitAnalysisJobResponse.AnalysisJob_.Template.MuxConfig_();

                SubmitAnalysisJobResponse.AnalysisJob_.Template.MuxConfig_.Segment_ segment = new SubmitAnalysisJobResponse.AnalysisJob_.Template.MuxConfig_.Segment_()
                {
                    Duration = context.StringValue($"SubmitAnalysisJob.AnalysisJob.TemplateList[{i}].MuxConfig.Segment.Duration")
                };
                muxConfig.Segment = segment;

                SubmitAnalysisJobResponse.AnalysisJob_.Template.MuxConfig_.Gif_ gif = new SubmitAnalysisJobResponse.AnalysisJob_.Template.MuxConfig_.Gif_()
                {
                    Loop = context.StringValue($"SubmitAnalysisJob.AnalysisJob.TemplateList[{i}].MuxConfig.Gif.Loop"),
                    FinalDelay = context.StringValue($"SubmitAnalysisJob.AnalysisJob.TemplateList[{i}].MuxConfig.Gif.FinalDelay")
                };
                muxConfig.Gif = gif;
				template.MuxConfig = muxConfig;

				templateList.Add(template);
			}
			analysisJob.TemplateList = templateList;
			submitAnalysisJobResponse.AnalysisJob = analysisJob;
        
			return submitAnalysisJobResponse;
        }
    }
}