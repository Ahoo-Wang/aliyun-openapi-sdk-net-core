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
using Aliyun.Acs.Cdn.Model.V20141111;
using System.Collections.Generic;

namespace Aliyun.Acs.Cdn.Transform.V20141111
{
    public class DescribeLiveStreamTranscodeInfoResponseUnmarshaller
    {
        public static DescribeLiveStreamTranscodeInfoResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeLiveStreamTranscodeInfoResponse describeLiveStreamTranscodeInfoResponse = new DescribeLiveStreamTranscodeInfoResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("DescribeLiveStreamTranscodeInfo.RequestId")
            };
            List<DescribeLiveStreamTranscodeInfoResponse.DomainTranscodeInfo> domainTranscodeList = new List<DescribeLiveStreamTranscodeInfoResponse.DomainTranscodeInfo>();
			for (int i = 0; i < context.Length("DescribeLiveStreamTranscodeInfo.DomainTranscodeList.Length"); i++) {
                DescribeLiveStreamTranscodeInfoResponse.DomainTranscodeInfo domainTranscodeInfo = new DescribeLiveStreamTranscodeInfoResponse.DomainTranscodeInfo()
                {
                    TranscodeApp = context.StringValue($"DescribeLiveStreamTranscodeInfo.DomainTranscodeList[{i}].TranscodeApp"),
                    TranscodeId = context.StringValue($"DescribeLiveStreamTranscodeInfo.DomainTranscodeList[{i}].TranscodeId"),
                    TranscodeName = context.StringValue($"DescribeLiveStreamTranscodeInfo.DomainTranscodeList[{i}].TranscodeName"),
                    TranscodeRecord = context.StringValue($"DescribeLiveStreamTranscodeInfo.DomainTranscodeList[{i}].TranscodeRecord"),
                    TranscodeSnapshot = context.StringValue($"DescribeLiveStreamTranscodeInfo.DomainTranscodeList[{i}].TranscodeSnapshot"),
                    TranscodeTemplate = context.StringValue($"DescribeLiveStreamTranscodeInfo.DomainTranscodeList[{i}].TranscodeTemplate")
                };
                domainTranscodeList.Add(domainTranscodeInfo);
			}
			describeLiveStreamTranscodeInfoResponse.DomainTranscodeList = domainTranscodeList;
        
			return describeLiveStreamTranscodeInfoResponse;
        }
    }
}