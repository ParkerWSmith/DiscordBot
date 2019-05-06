using System;

public class JAV
{
    public DmmParsingProfile(boolean doGoogleTranslation)
    {
        super();
        this.doGoogleTranslation = doGoogleTranslation;
        if (this.doGoogleTranslation == false)
            setScrapingLanguage(Language.JAPANESE);
        scrapeTrailers = true;
    }

    public DmmParsingProfile(boolean doGoogleTranslation, boolean scrapeTrailers)
    {
        super();
        this.doGoogleTranslation = doGoogleTranslation;
        if (this.doGoogleTranslation == false)
            setScrapingLanguage(Language.JAPANESE);
        this.scrapeTrailers = scrapeTrailers;
    }

    public DmmParsingProfile(Document document, boolean doGoogleTranslation)
    {
        super(document);
        this.doGoogleTranslation = doGoogleTranslation;
        if (this.doGoogleTranslation == false)
            setScrapingLanguage(Language.JAPANESE);
    }
    public Title scrapeTitle()
        {
            Element titleElement = document.select("[property=og:title]").first();
            // run a google translate on the japanese title
            if (doGoogleTranslation)
            {
                return new Title(TranslateString.translateStringJapaneseToEnglish(titleElement.attr("content").toString()));
            }
            else
            {
                return new Title(titleElement.attr("content").toString());
            }
        }
}
