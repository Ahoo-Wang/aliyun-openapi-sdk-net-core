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
    public class DescribeDomainTopUrlVisitResponseUnmarshaller
    {
        public static DescribeDomainTopUrlVisitResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeDomainTopUrlVisitResponse describeDomainTopUrlVisitResponse = new DescribeDomainTopUrlVisitResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("DescribeDomainTopUrlVisit.RequestId"),
                DomainName = context.StringValue("DescribeDomainTopUrlVisit.DomainName"),
                StartTime = context.StringValue("DescribeDomainTopUrlVisit.StartTime")
            };
            List<DescribeDomainTopUrlVisitResponse.UrlList> allUrlList = new List<DescribeDomainTopUrlVisitResponse.UrlList>();
			for (int i = 0; i < context.Length("DescribeDomainTopUrlVisit.AllUrlList.Length"); i++) {
                DescribeDomainTopUrlVisitResponse.UrlList urlList = new DescribeDomainTopUrlVisitResponse.UrlList()
                {
                    UrlDetail = context.StringValue($"DescribeDomainTopUrlVisit.AllUrlList[{i}].UrlDetail"),
                    VisitData = context.StringValue($"DescribeDomainTopUrlVisit.AllUrlList[{i}].VisitData"),
                    VisitProportion = context.FloatValue($"DescribeDomainTopUrlVisit.AllUrlList[{i}].VisitProportion"),
                    Flow = context.StringValue($"DescribeDomainTopUrlVisit.AllUrlList[{i}].Flow"),
                    FlowProportion = context.FloatValue($"DescribeDomainTopUrlVisit.AllUrlList[{i}].FlowProportion")
                };
                allUrlList.Add(urlList);
			}
			describeDomainTopUrlVisitResponse.AllUrlList = allUrlList;

			List<DescribeDomainTopUrlVisitResponse.UrlList> url200List = new List<DescribeDomainTopUrlVisitResponse.UrlList>();
			for (int i = 0; i < context.Length("DescribeDomainTopUrlVisit.Url200List.Length"); i++) {
                DescribeDomainTopUrlVisitResponse.UrlList urlList = new DescribeDomainTopUrlVisitResponse.UrlList()
                {
                    UrlDetail = context.StringValue($"DescribeDomainTopUrlVisit.Url200List[{i}].UrlDetail"),
                    VisitData = context.StringValue($"DescribeDomainTopUrlVisit.Url200List[{i}].VisitData"),
                    VisitProportion = context.FloatValue($"DescribeDomainTopUrlVisit.Url200List[{i}].VisitProportion"),
                    Flow = context.StringValue($"DescribeDomainTopUrlVisit.Url200List[{i}].Flow"),
                    FlowProportion = context.FloatValue($"DescribeDomainTopUrlVisit.Url200List[{i}].FlowProportion")
                };
                url200List.Add(urlList);
			}
			describeDomainTopUrlVisitResponse.Url200List = url200List;

			List<DescribeDomainTopUrlVisitResponse.UrlList> url300List = new List<DescribeDomainTopUrlVisitResponse.UrlList>();
			for (int i = 0; i < context.Length("DescribeDomainTopUrlVisit.Url300List.Length"); i++) {
                DescribeDomainTopUrlVisitResponse.UrlList urlList = new DescribeDomainTopUrlVisitResponse.UrlList()
                {
                    UrlDetail = context.StringValue($"DescribeDomainTopUrlVisit.Url300List[{i}].UrlDetail"),
                    VisitData = context.StringValue($"DescribeDomainTopUrlVisit.Url300List[{i}].VisitData"),
                    VisitProportion = context.FloatValue($"DescribeDomainTopUrlVisit.Url300List[{i}].VisitProportion"),
                    Flow = context.StringValue($"DescribeDomainTopUrlVisit.Url300List[{i}].Flow"),
                    FlowProportion = context.FloatValue($"DescribeDomainTopUrlVisit.Url300List[{i}].FlowProportion")
                };
                url300List.Add(urlList);
			}
			describeDomainTopUrlVisitResponse.Url300List = url300List;

			List<DescribeDomainTopUrlVisitResponse.UrlList> url400List = new List<DescribeDomainTopUrlVisitResponse.UrlList>();
			for (int i = 0; i < context.Length("DescribeDomainTopUrlVisit.Url400List.Length"); i++) {
                DescribeDomainTopUrlVisitResponse.UrlList urlList = new DescribeDomainTopUrlVisitResponse.UrlList()
                {
                    UrlDetail = context.StringValue($"DescribeDomainTopUrlVisit.Url400List[{i}].UrlDetail"),
                    VisitData = context.StringValue($"DescribeDomainTopUrlVisit.Url400List[{i}].VisitData"),
                    VisitProportion = context.FloatValue($"DescribeDomainTopUrlVisit.Url400List[{i}].VisitProportion"),
                    Flow = context.StringValue($"DescribeDomainTopUrlVisit.Url400List[{i}].Flow"),
                    FlowProportion = context.FloatValue($"DescribeDomainTopUrlVisit.Url400List[{i}].FlowProportion")
                };
                url400List.Add(urlList);
			}
			describeDomainTopUrlVisitResponse.Url400List = url400List;

			List<DescribeDomainTopUrlVisitResponse.UrlList> url500List = new List<DescribeDomainTopUrlVisitResponse.UrlList>();
			for (int i = 0; i < context.Length("DescribeDomainTopUrlVisit.Url500List.Length"); i++) {
                DescribeDomainTopUrlVisitResponse.UrlList urlList = new DescribeDomainTopUrlVisitResponse.UrlList()
                {
                    UrlDetail = context.StringValue($"DescribeDomainTopUrlVisit.Url500List[{i}].UrlDetail"),
                    VisitData = context.StringValue($"DescribeDomainTopUrlVisit.Url500List[{i}].VisitData"),
                    VisitProportion = context.FloatValue($"DescribeDomainTopUrlVisit.Url500List[{i}].VisitProportion"),
                    Flow = context.StringValue($"DescribeDomainTopUrlVisit.Url500List[{i}].Flow"),
                    FlowProportion = context.FloatValue($"DescribeDomainTopUrlVisit.Url500List[{i}].FlowProportion")
                };
                url500List.Add(urlList);
			}
			describeDomainTopUrlVisitResponse.Url500List = url500List;
        
			return describeDomainTopUrlVisitResponse;
        }
    }
}