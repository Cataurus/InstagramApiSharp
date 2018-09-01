﻿using System;
using System.Threading.Tasks;
using InstagramApiSharp.Classes;
using InstagramApiSharp.Classes.Models;

namespace InstagramApiSharp.API.Processors
{
    public interface IMessagingProcessor
    {
        /// <summary>
        ///     Get direct inbox threads for current user asynchronously
        /// </summary>
        /// <returns>
        ///     <see cref="T:InstagramApiSharp.Classes.Models.InstaDirectInboxContainer" />
        /// </returns>
        Task<IResult<InstaDirectInboxContainer>> GetDirectInboxAsync(string nextOrCursorId = "");
        /// <summary>
        ///     Get direct inbox thread by its id asynchronously
        /// </summary>
        /// <param name="threadId">Thread id</param>
        /// <returns>
        ///     <see cref="InstaDirectInboxThread" />
        /// </returns>
        Task<IResult<InstaDirectInboxThread>> GetDirectInboxThreadAsync(string threadId, string nextOrCursorId = "");
        /// <summary>
        ///     Send new direct message. (use this function, if you didn't send any message to this user before)
        /// </summary>
        /// <param name="username">Username to send</param>
        /// <param name="text">Message text</param>
        /// <returns>List of threads</returns>
        Task<IResult<InstaDirectInboxThreadList>> SendNewDirectMessageAsync(string username, string text);
        /// <summary>
        ///     Send direct message to provided users and threads
        /// </summary>
        /// <param name="recipients">Comma-separated users PK</param>
        /// <param name="threadIds">Message thread ids</param>
        /// <param name="text">Message text</param>
        /// <returns>List of threads</returns>
        Task<IResult<InstaDirectInboxThreadList>> SendDirectMessageAsync(string recipients, string threadIds,
            string text);
        /// <summary>
        ///     Get recent recipients (threads and users) asynchronously
        /// </summary>
        /// <returns>
        ///     <see cref="InstaRecipients" />
        /// </returns>
        Task<IResult<InstaRecipients>> GetRecentRecipientsAsync();
        /// <summary>
        ///     Get ranked recipients (threads and users) asynchronously
        /// </summary>
        /// <returns>
        ///     <see cref="InstaRecipients" />
        /// </returns>
        Task<IResult<InstaRecipients>> GetRankedRecipientsAsync();
        /// <summary>
        ///     Approve direct pending request
        /// </summary>
        /// <param name="threadId">Thread id</param>
        Task<IResult<bool>> ApproveDirectPendingRequestAsync(string threadId);
        /// <summary>
        ///     Decline all direct pending requests
        /// </summary>
        Task<IResult<bool>> DeclineAllDirectPendingRequestsAsync();
        /// <summary>
        ///     Get direct pending inbox threads for current user asynchronously
        /// </summary>
        /// <returns>
        ///     <see cref="T:InstagramApiSharp.Classes.Models.InstaDirectInboxContainer" />
        /// </returns>
        Task<IResult<InstaDirectInboxContainer>> GetPendingDirectAsync(string nextOrCursorId = "");
        /// <summary>
        ///     Share an user
        /// </summary>
        /// <param name="userIdToSend">User id(PK)</param>
        /// <param name="threadId">Thread id</param>
        Task<IResult<InstaSharing>> ShareUserAsync(string userIdToSend, string threadId);
        /// <summary>
        ///     Send photo to direct thread (single)
        /// </summary>
        /// <param name="image">Image to upload</param>
        /// <param name="threadId">Thread id</param>
        /// <returns>Returns True is sent</returns>
        Task<IResult<bool>> SendDirectPhotoAsync(InstaImage image, string threadId);
        /// <summary>
        ///     Send photo to multiple recipients (multiple user)
        /// </summary>
        /// <param name="image">Image to upload</param>
        /// <param name="recipients">Recipients (user ids/pk)</param>
        /// <returns>Returns True is sent</returns>
        Task<IResult<bool>> SendDirectPhotoToRecipientsAsync(InstaImage image, params string[] recipients);
        /// <summary>
        ///     Send video to direct thread (single)
        /// </summary>
        /// <param name="video">Video to upload (no need to set thumbnail)</param>
        /// <param name="threadId">Thread id</param>
        Task<IResult<bool>> SendDirectVideoAsync(InstaVideoUpload video, string threadId);
        /// <summary>
        ///     Send video to multiple recipients (multiple user)
        /// </summary>
        /// <param name="video">Video to upload (no need to set thumbnail)</param>
        /// <param name="recipients">Recipients (user ids/pk)</param>
        Task<IResult<bool>> SendDirectVideoToRecipientsAsync(InstaVideoUpload video, params string[] recipients);


    }
}