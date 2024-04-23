using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    /// <summary>
    /// Хранит данные о цветах.
    /// </summary>
    public static class AppColors
    {
        /// <summary>
        /// Цвет для правильного значения в TextBox.
        /// </summary>
        public static readonly Color ValidatorTrueColor = Color.White;
        /// <summary>
        /// Цвет для некорректного значения в TextBox.
        /// </summary>
        public static readonly Color ValidatorFalseColor = Color.LightPink;
        /// <summary>
        /// Цвет для отображения пересечения.
        /// </summary>
        public static readonly Color CollisionTrue = Color.FromArgb(127, 255, 127, 127);
        /// <summary>
        /// Цвет для отображения непересечения.
        /// </summary>
        public static readonly Color CollisionFalse = Color.FromArgb(127, 127, 255, 127);
    }
}
