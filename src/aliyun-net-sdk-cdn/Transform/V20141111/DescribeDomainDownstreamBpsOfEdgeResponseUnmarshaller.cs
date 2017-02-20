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
    public class DescribeDomainDownstreamBpsOfEdgeResponseUnmarshaller
    {
        public static DescribeDomainDownstreamBpsOfEdgeResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeDomainDownstreamBpsOfEdgeResponse describeDomainDownstreamBpsOfEdgeResponse = new DescribeDomainDownstreamBpsOfEdgeResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("DescribeDomainDownstreamBpsOfEdge.RequestId")
            };
            List<DescribeDomainDownstreamBpsOfEdgeResponse.DomainBpsModel> bpsDatas = new List<DescribeDomainDownstreamBpsOfEdgeResponse.DomainBpsModel>();
			for (int i = 0; i < context.Length("DescribeDomainDownstreamBpsOfEdge.BpsDatas.Length"); i++) {
                DescribeDomainDownstreamBpsOfEdgeResponse.DomainBpsModel domainBpsModel = new DescribeDomainDownstreamBpsOfEdgeResponse.DomainBpsModel()
                {
                    Time = context.StringValue($"DescribeDomainDownstreamBpsOfEdge.BpsDatas[{i}].Time"),
                    Bps = context.FloatValue($"DescribeDomainDownstreamBpsOfEdge.BpsDatas[{i}].Bps")
                };
                bpsDatas.Add(domainBpsModel);
			}
			describeDomainDownstreamBpsOfEdgeResponse.BpsDatas = bpsDatas;
        
			return describeDomainDownstreamBpsOfEdgeResponse;
        }
    }
}