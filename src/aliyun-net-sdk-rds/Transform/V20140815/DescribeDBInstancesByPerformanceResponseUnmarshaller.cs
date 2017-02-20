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
    public class DescribeDBInstancesByPerformanceResponseUnmarshaller
    {
        public static DescribeDBInstancesByPerformanceResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeDBInstancesByPerformanceResponse describeDBInstancesByPerformanceResponse = new DescribeDBInstancesByPerformanceResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("DescribeDBInstancesByPerformance.RequestId"),
                PageNumber = context.IntegerValue("DescribeDBInstancesByPerformance.PageNumber"),
                TotalRecordCount = context.IntegerValue("DescribeDBInstancesByPerformance.TotalRecordCount"),
                PageRecordCount = context.IntegerValue("DescribeDBInstancesByPerformance.PageRecordCount")
            };
            List<DescribeDBInstancesByPerformanceResponse.DBInstancePerformance> items = new List<DescribeDBInstancesByPerformanceResponse.DBInstancePerformance>();
			for (int i = 0; i < context.Length("DescribeDBInstancesByPerformance.Items.Length"); i++) {
                DescribeDBInstancesByPerformanceResponse.DBInstancePerformance dBInstancePerformance = new DescribeDBInstancesByPerformanceResponse.DBInstancePerformance()
                {
                    CpuUsage = context.StringValue($"DescribeDBInstancesByPerformance.Items[{i}].CPUUsage"),
                    IopsUsage = context.StringValue($"DescribeDBInstancesByPerformance.Items[{i}].IOPSUsage"),
                    DiskUsage = context.StringValue($"DescribeDBInstancesByPerformance.Items[{i}].DiskUsage"),
                    SessionUsage = context.StringValue($"DescribeDBInstancesByPerformance.Items[{i}].SessionUsage"),
                    DBInstanceId = context.StringValue($"DescribeDBInstancesByPerformance.Items[{i}].DBInstanceId"),
                    DBInstanceDescription = context.StringValue($"DescribeDBInstancesByPerformance.Items[{i}].DBInstanceDescription")
                };
                items.Add(dBInstancePerformance);
			}
			describeDBInstancesByPerformanceResponse.Items = items;
        
			return describeDBInstancesByPerformanceResponse;
        }
    }
}