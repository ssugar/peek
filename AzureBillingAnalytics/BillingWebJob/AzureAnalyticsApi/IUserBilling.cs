﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using BillingWebJob.Models;
using Microsoft.Rest;

namespace BillingWebJob
{
    public partial interface IUserBilling
    {
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        Task<HttpOperationResponse<IList<UsageInfoModel>>> GetCurrentMonthDataWithOperationResponseAsync(
            CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <param name='startDateValue'>
        /// Required.
        /// </param>
        /// <param name='endDateValue'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        Task<HttpOperationResponse<IList<UsageInfoModel>>> GetDataForMonthRangeWithOperationResponseAsync(
            string startDateValue, string endDateValue,
            CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <param name='mMYYYY'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        Task<HttpOperationResponse<IList<UsageInfoModel>>> GetSingleMonthDataWithOperationResponseAsync(string mMYYYY,
            CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    }
}