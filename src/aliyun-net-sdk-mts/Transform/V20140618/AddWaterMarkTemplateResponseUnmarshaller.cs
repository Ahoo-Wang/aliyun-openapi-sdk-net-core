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

namespace Aliyun.Acs.Mts.Transform.V20140618
{
    public class AddWaterMarkTemplateResponseUnmarshaller
    {
        public static AddWaterMarkTemplateResponse Unmarshall(UnmarshallerContext context)
        {
            AddWaterMarkTemplateResponse addWaterMarkTemplateResponse = new AddWaterMarkTemplateResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("AddWaterMarkTemplate.RequestId")
            };
            AddWaterMarkTemplateResponse.WaterMarkTemplate_ waterMarkTemplate = new AddWaterMarkTemplateResponse.WaterMarkTemplate_()
            {
                Id = context.StringValue("AddWaterMarkTemplate.WaterMarkTemplate.Id"),
                Name = context.StringValue("AddWaterMarkTemplate.WaterMarkTemplate.Name"),
                Width = context.StringValue("AddWaterMarkTemplate.WaterMarkTemplate.Width"),
                Height = context.StringValue("AddWaterMarkTemplate.WaterMarkTemplate.Height"),
                Dx = context.StringValue("AddWaterMarkTemplate.WaterMarkTemplate.Dx"),
                Dy = context.StringValue("AddWaterMarkTemplate.WaterMarkTemplate.Dy"),
                ReferPos = context.StringValue("AddWaterMarkTemplate.WaterMarkTemplate.ReferPos"),
                Type = context.StringValue("AddWaterMarkTemplate.WaterMarkTemplate.Type"),
                State = context.StringValue("AddWaterMarkTemplate.WaterMarkTemplate.State")
            };
            addWaterMarkTemplateResponse.WaterMarkTemplate = waterMarkTemplate;
        
			return addWaterMarkTemplateResponse;
        }
    }
}