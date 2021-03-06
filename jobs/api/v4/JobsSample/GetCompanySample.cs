﻿// Copyright 2020 Google Inc.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
using Google.Cloud.Talent.V4Beta1;

namespace GoogleCloudSamples
{
    internal class GetCompanySample
    {
        // [START job_search_get_company_beta]
        public static object GetCompany(string projectId, string tenantId, string companyId)
        {
            CompanyServiceClient companyServiceClient = CompanyServiceClient.Create();
            CompanyName company = new CompanyName(projectId, tenantId, companyId);

            GetCompanyRequest request = new GetCompanyRequest
            {
                CompanyNameOneof = CompanyNameOneof.From(company)
            };
            var response = companyServiceClient.GetCompany(request);
            Console.WriteLine($"Company name: {response.Name}");
            Console.WriteLine($"Display name: {response.DisplayName}");
            return 0;
        }
        // [END job_search_get_company_beta]
    }
}
