﻿namespace RxBim.Tools
{
    using System;
    using System.Collections.Generic;
    using JetBrains.Annotations;

    /// <summary>
    /// Represents a type that is used for error logging.
    /// </summary>
    [PublicAPI]
    public interface ILogStorage
    {
        /// <summary>
        /// An event that is raised when a collection of storage items changes.
        /// </summary>
        [UsedImplicitly]
        event EventHandler ElementStorageChanged;

        /// <summary>
        /// Adds message to storage
        /// </summary>
        /// <param name="message">Message</param>
        /// <typeparam name="T">Message type</typeparam>
        [UsedImplicitly]
        public void AddMessage<T>(in T message)
            where T : ILogMessage;

        /// <summary>
        /// Returns message collection
        /// </summary>
        [UsedImplicitly]
        IEnumerable<ILogMessage> GetMessages();

        /// <summary>
        /// Indicates that storage has messages
        /// </summary>
        [UsedImplicitly]
        bool HasMessages();

        /// <summary>
        /// Clears message storage
        /// </summary>
        [UsedImplicitly]
        void Clear();
    }
}