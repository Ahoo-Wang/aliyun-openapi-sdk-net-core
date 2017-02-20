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
using Aliyun.Acs.Rds.Model.V20140815;
using System.Collections.Generic;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class DescribeSQLLogReportListResponseUnmarshaller
    {
        public static DescribeSQLLogReportListResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeSQLLogReportListResponse describeSQLLogReportListResponse = new DescribeSQLLogReportListResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("DescribeSQLLogReportList.RequestId"),
                TotalRecordCount = context.IntegerValue("DescribeSQLLogReportList.TotalRecordCount"),
                PageNumber = context.IntegerValue("DescribeSQLLogReportList.PageNumber"),
                PageRecordCount = context.IntegerValue("DescribeSQLLogReportList.PageRecordCount")
            };
            List<DescribeSQLLogReportListResponse.Item> items = new List<DescribeSQLLogReportListResponse.Item>();
			for (int i = 0; i < context.Length("DescribeSQLLogReportList.Items.Length"); i++) {
                DescribeSQLLogReportListResponse.Item item = new DescribeSQLLogReportListResponse.Item()
                {
                    ReportTime = context.StringValue($"DescribeSQLLogReportList.Items[{i}].ReportTime")
                };
                List<DescribeSQLLogReportListResponse.Item.LatencyTopNItem> latencyTopNItems = new List<DescribeSQLLogReportListResponse.Item.LatencyTopNItem>();
				for (int j = 0; j < context.Length($"DescribeSQLLogReportList.Items[{i}].LatencyTopNItems.Length"); j++) {
                    DescribeSQLLogReportListResponse.Item.LatencyTopNItem latencyTopNItem = new DescribeSQLLogReportListResponse.Item.LatencyTopNItem()
                    {
                        SQLText = context.StringValue($"DescribeSQLLogReportList.Items[{i}].LatencyTopNItems[{j}].SQLText"),
                        AvgLatency = context.LongValue($"DescribeSQLLogReportList.Items[{i}].LatencyTopNItems[{j}].AvgLatency"),
                        SQLExecuteTimes = context.LongValue($"DescribeSQLLogReportList.Items[{i}].LatencyTopNItems[{j}].SQLExecuteTimes")
                    };
                    latencyTopNItems.Add(latencyTopNItem);
				}
				item.LatencyTopNItems = latencyTopNItems;

				List<DescribeSQLLogReportListResponse.Item.QpsTopNItem> qPsTopNItems = new List<DescribeSQLLogReportListResponse.Item.QpsTopNItem>();
				for (int j = 0; j < context.Length($"DescribeSQLLogReportList.Items[{i}].QPSTopNItems.Length"); j++) {
                    DescribeSQLLogReportListResponse.Item.QpsTopNItem qPsTopNItem = new DescribeSQLLogReportListResponse.Item.QpsTopNItem()
                    {
                        SQLText = context.StringValue($"DescribeSQLLogReportList.Items[{i}].QPSTopNItems[{j}].SQLText"),
                        SQLExecuteTimes = context.LongValue($"DescribeSQLLogReportList.Items[{i}].QPSTopNItems[{j}].SQLExecuteTimes")
                    };
                    qPsTopNItems.Add(qPsTopNItem);
				}
				item.QpsTopNItems = qPsTopNItems;

				items.Add(item);
			}
			describeSQLLogReportListResponse.Items = items;
        
			return describeSQLLogReportListResponse;
        }
    }
}