﻿#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.472/blob/master/LICENSE
 *
 */
#endregion

using System.Drawing;

namespace ExtendedControls.Base.Code.Models.Typeface
{
    public class TypefaceModel
    {
        #region Properties
        /// <summary>
        /// Gets or sets the typeface.
        /// </summary>
        /// <value>
        /// The typeface.
        /// </value>
        public FontFamily Typeface { get; set; }

        /// <summary>
        /// Gets or sets the typeface file path.
        /// </summary>
        /// <value>
        /// The typeface file path.
        /// </value>
        public string TypefaceFilePath { get; set; }

        /// <summary>
        /// Gets or sets the name of the typeface.
        /// </summary>
        /// <value>
        /// The name of the typeface.
        /// </value>
        public string TypefaceName { get; set; }
        #endregion

        #region Overrides
        public override string ToString()
        {
            return (Typeface != null ? Typeface.Name : base.ToString());
        }
        #endregion
    }
}