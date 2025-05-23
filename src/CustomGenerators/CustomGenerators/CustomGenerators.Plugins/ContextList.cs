using System.Collections.Generic;
using System.Linq;

namespace CustomGenerators.Plugins
{
  public class ContextList
  {
    public List<string> ContextNames { get; }

    public ContextList(IEnumerable<string> contextNames)
    {
      ContextNames = contextNames.ToList();
    }
  }
}