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
    public class DescribeDomainHitRateDataResponseUnmarshaller
    {
        public static DescribeDomainHitRateDataResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeDomainHitRateDataResponse describeDomainHitRateDataResponse = new DescribeDomainHitRateDataResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("DescribeDomainHitRateData.RequestId"),
                DomainName = context.StringValue("DescribeDomainHitRateData.DomainName"),
                DataInterval = context.StringValue("DescribeDomainHitRateData.DataInterval"),
                StartTime = context.StringValue("DescribeDomainHitRateData.StartTime"),
                EndTime = context.StringValue("DescribeDomainHitRateData.EndTime")
            };
            List<DescribeDomainHitRateDataResponse.DataModule> hitRateInterval = new List<DescribeDomainHitRateDataResponse.DataModule>();
			for (int i = 0; i < context.Length("DescribeDomainHitRateData.HitRateInterval.Length"); i++) {
                DescribeDomainHitRateDataResponse.DataModule dataModule = new DescribeDomainHitRateDataResponse.DataModule()
                {
                    TimeStamp = context.StringValue($"DescribeDomainHitRateData.HitRateInterval[{i}].TimeStamp"),
                    Value = context.StringValue($"DescribeDomainHitRateData.HitRateInterval[{i}].Value")
                };
                hitRateInterval.Add(dataModule);
			}
			describeDomainHitRateDataResponse.HitRateInterval = hitRateInterval;
        
			return describeDomainHitRateDataResponse;
        }
    }
}