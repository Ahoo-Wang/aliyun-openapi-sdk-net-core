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
    public class DescribeLiveRecordConfigResponseUnmarshaller
    {
        public static DescribeLiveRecordConfigResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeLiveRecordConfigResponse describeLiveRecordConfigResponse = new DescribeLiveRecordConfigResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("DescribeLiveRecordConfig.RequestId")
            };
            List<DescribeLiveRecordConfigResponse.LiveAppRecord> liveAppRecordList = new List<DescribeLiveRecordConfigResponse.LiveAppRecord>();
			for (int i = 0; i < context.Length("DescribeLiveRecordConfig.LiveAppRecordList.Length"); i++) {
                DescribeLiveRecordConfigResponse.LiveAppRecord liveAppRecord = new DescribeLiveRecordConfigResponse.LiveAppRecord()
                {
                    DomainName = context.StringValue($"DescribeLiveRecordConfig.LiveAppRecordList[{i}].DomainName"),
                    AppName = context.StringValue($"DescribeLiveRecordConfig.LiveAppRecordList[{i}].AppName"),
                    OssEndpoint = context.StringValue($"DescribeLiveRecordConfig.LiveAppRecordList[{i}].OssEndpoint"),
                    OssBucket = context.StringValue($"DescribeLiveRecordConfig.LiveAppRecordList[{i}].OssBucket"),
                    OssObjectPrefix = context.StringValue($"DescribeLiveRecordConfig.LiveAppRecordList[{i}].OssObjectPrefix"),
                    CreateTime = context.StringValue($"DescribeLiveRecordConfig.LiveAppRecordList[{i}].CreateTime")
                };
                liveAppRecordList.Add(liveAppRecord);
			}
			describeLiveRecordConfigResponse.LiveAppRecordList = liveAppRecordList;
        
			return describeLiveRecordConfigResponse;
        }
    }
}