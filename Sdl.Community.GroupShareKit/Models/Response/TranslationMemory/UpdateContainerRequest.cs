﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sdl.Community.GroupShareKit.Models.Response.TranslationMemory
{
    public class UpdateContainerRequest
    {
        /// <summary>
        /// Gets or sets container id
        /// </summary>
        public string ContainerId { get; set; }
        /// <summary>
        /// Gets or sets display name
        /// </summary>
        public string DisplayName { get; set; }
        /// <summary>
        /// Gets or sets if is shared
        /// </summary>
        public bool IsShared { get; set; }
    }
}
