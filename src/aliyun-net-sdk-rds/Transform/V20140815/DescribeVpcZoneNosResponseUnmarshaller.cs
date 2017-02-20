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
    public class DescribeVpcZoneNosResponseUnmarshaller
    {
        public static DescribeVpcZoneNosResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeVpcZoneNosResponse describeVpcZoneNosResponse = new DescribeVpcZoneNosResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("DescribeVpcZoneNos.RequestId")
            };
            List<DescribeVpcZoneNosResponse.VpcZoneId> items = new List<DescribeVpcZoneNosResponse.VpcZoneId>();
			for (int i = 0; i < context.Length("DescribeVpcZoneNos.Items.Length"); i++) {
                DescribeVpcZoneNosResponse.VpcZoneId vpcZoneId = new DescribeVpcZoneNosResponse.VpcZoneId()
                {
                    ZoneId = context.StringValue($"DescribeVpcZoneNos.Items[{i}].ZoneId"),
                    Region = context.StringValue($"DescribeVpcZoneNos.Items[{i}].Region"),
                    SubDomain = context.StringValue($"DescribeVpcZoneNos.Items[{i}].SubDomain")
                };
                items.Add(vpcZoneId);
			}
			describeVpcZoneNosResponse.Items = items;
        
			return describeVpcZoneNosResponse;
        }
    }
}