using System.Collections.Generic;

namespace mage {
    // Importer interface allows the conversion tool to support multiple source font formats.
    public interface IFontImporter {
        void Import(CommandLineOptions options);

        IEnumerable<Glyph> Glyphs { get; }

        float LineSpacing { get; }
    }
}
