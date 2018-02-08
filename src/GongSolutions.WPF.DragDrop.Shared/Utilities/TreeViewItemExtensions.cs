using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace GongSolutions.Wpf.DragDrop.Utilities
{
  /// <summary>
  /// Extension methods for TreeViewItem
  /// </summary>
  public static class TreeViewItemExtensions
  {
    /// <summary>
    /// Try get the height of the header part for the given TreeViewItem.
    /// If there is no PART_Header it will return Size.Empty.
    /// </summary>
    /// <param name="item">The TreeViewItem.</param>
    public static Size GetHeaderSize(this TreeViewItem item)
    {
      if (item == null)
      {
        return Size.Empty;
      }
      var header = GetHeaderControl(item);
      return header != null ? new Size(header.ActualWidth, header.ActualHeight) : item.RenderSize;
    }

    /// <summary>
    /// Try get the header part of the given TreeViewItem.
    /// If there is no PART_Header it will return null.
    /// </summary>
    /// <param name="item">The TreeViewItem.</param>
    public static FrameworkElement GetHeaderControl(this TreeViewItem item)
    {
      return item?.Template?.FindName("PART_Header", item) as FrameworkElement;
    }
  }

  #region IUEditor 
#if NET45
  /// <summary>
  /// Extension methods for TreeViewItem
  /// </summary>
  public static class MultiSelectTreeViewItemExtensions
  {
    /// <summary>
    /// Try get the height of the header part for the given MultiSelectTreeViewItem.
    /// If there is no PART_Header it will return Size.Empty.
    /// </summary>
    /// <param name="item">The MultiSelectTreeViewItem.</param>
    public static Size GetHeaderSize(this MultiSelectTreeViewItem item)
    {
      if (item == null)
      {
        return Size.Empty;
      }
      var header = GetHeaderControl(item);
      return header != null ? new Size(header.ActualWidth, header.ActualHeight) : item.RenderSize;
    }

    /// <summary>
    /// Try get the header part of the given TreeViewItem.
    /// If there is first row of stack panel
    /// </summary>
    /// <param name="item">The MultiSelectTreeViewItem.</param>
    public static FrameworkElement GetHeaderControl(this MultiSelectTreeViewItem item)
    {
      /**
       * template 
       * stack panel
       *  - grid : header
       *  - grid : children treeview items
       */ 
      FrameworkElement panel = VisualTreeHelper.GetChild(item, 0) as FrameworkElement;
      FrameworkElement header = VisualTreeHelper.GetChild(panel, 0) as FrameworkElement;
      return header;
    }
  }
#endif
  #endregion
}