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
    public class DescribeLiveStreamBpsDataResponseUnmarshaller
    {
        public static DescribeLiveStreamBpsDataResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeLiveStreamBpsDataResponse describeLiveStreamBpsDataResponse = new DescribeLiveStreamBpsDataResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("DescribeLiveStreamBpsData.RequestId")
            };
            List<DescribeLiveStreamBpsDataResponse.DomainBpsModel> bpsDatas = new List<DescribeLiveStreamBpsDataResponse.DomainBpsModel>();
			for (int i = 0; i < context.Length("DescribeLiveStreamBpsData.BpsDatas.Length"); i++) {
                DescribeLiveStreamBpsDataResponse.DomainBpsModel domainBpsModel = new DescribeLiveStreamBpsDataResponse.DomainBpsModel()
                {
                    Time = context.StringValue($"DescribeLiveStreamBpsData.BpsDatas[{i}].Time"),
                    Bps = context.FloatValue($"DescribeLiveStreamBpsData.BpsDatas[{i}].Bps")
                };
                bpsDatas.Add(domainBpsModel);
			}
			describeLiveStreamBpsDataResponse.BpsDatas = bpsDatas;
        
			return describeLiveStreamBpsDataResponse;
        }
    }
}