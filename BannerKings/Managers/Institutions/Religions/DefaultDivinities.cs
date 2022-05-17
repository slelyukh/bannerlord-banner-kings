﻿using TaleWorlds.Localization;

namespace BannerKings.Managers.Institutions.Religions
{
    public class DefaultDivinities
    {
        private Divinity aseraMain, aseraSecondary1, aseraSecondary2, aseraSecondary3,
            amraMain, amraSecondary1, amraSecondary2, darusosianMain, darusosianSecondary1, darusosianSecondary2;

        public static DefaultDivinities Instance => ConfigHolder.CONFIG;

        internal struct ConfigHolder
        {
            public static DefaultDivinities CONFIG = new DefaultDivinities();
        }

        public void Initialize()
        {
            aseraMain = new Divinity(new TextObject("{=!}Asera the Patriarch"), 
                new TextObject("{=!}First of his line, the legendary patriarch united the various badw tribes of the Nahasa and the coastal Behr al-Yeshm into the lawful confederacy of the Aserai Sultanate. Asera was deified by his deeds and the codes of law which allowed him to establish dominion and settle his people from the Jabal Tamar to the Jabal Ashab. Asera is that which all followers of his Code seek to live up to; though most followers will accept that the words of Asera are transcribed to benefit the bloodlines which followed him. Thus one can only ever seek to live as Asera did, and to know only their success upon arrival in Paradise."), 
                new TextObject());

            aseraSecondary1 = new Divinity(new TextObject("{=!}Damma-Siddiq"),
                new TextObject("{=!}Descended from those who dedicated themselves to the Code of Asera but who were married into the true bloodlines of Asera’s descendents are known as the Damma-Siddiq; those of truthful blood. It is through their reforms, compromises, and bold rhetoric that marriage may allow even those born outside the Sultanate to come to be viewed as being of the blood of Asera - albeit through legalism and spirit."),
                new TextObject());

            aseraSecondary2 = new Divinity(new TextObject("{=!}Rashuqqalih"),
                new TextObject("{=!}Only the direct line of Asera’s sons can claim to be Ibn-Zakaa; to be born a Pure Son. Such claims have led to kinstrife and civil war in the past, with daughters being viewed as a dead end to a pure line, and many a ‘lesser son’ made eunuch as means of societal control. In the modern age, the Ibn-Zakaa are far more enlightened, viewing themselves not as deserving of a divinely appointed respect but rather in the light of those who have much to prove to be worthy in the eyes of their progenitor."),
                new TextObject());

            aseraSecondary3 = new Divinity(new TextObject("{=!}Damma-Siddiq"),
                new TextObject("{=!}The schools of philosophy preached by the Rashuqqalih practitioners of the Code, are concerned foremost with matters of righteousness and societal elegance. To be of the blood of Asera is to be bound to the morals of a mortal man made legendary, and thus matters of failure and mortal flaws must be treated with compassion. The most famous practitioner of the Rashuqqalih school was Queen Eshora, who brought several nomadic badw tribes into the Sultanate by accepting their adherence to tradition as a thing to be celebrated, rather than as a matter to consider them a distasteful other."),
                new TextObject());


            amraMain = new Divinity(new TextObject("{=!}Sluagh Aos’An"), 
                new TextObject("{=!}Constituting the major heavenly divine of the Battanians are those known as the Slaugh Aos’An - the Host of Noble Folk who reign between darkened clouds and watch over humanity with starlight torches. Seldom petitioned, as they are viewed as capricious entities; the Slaugh Aos’An are said to visit Battania during the changing of the seasons and to witness the birth of those ordained by fate to bring about weal and doom to the land. To make an oath under the auspices of the Slaugh Aos’An is to be bound to the letter or the spirit of one’s words; never more and never both. To break such an oath is to invite all of fate to conspire towards your end, and to know no peace in Heaven nor Hell."),
                new TextObject());

            amraSecondary1 = new Divinity(new TextObject("{=!}Na Sidhfir"),
                new TextObject("{=!}Those deemed to have won the favor of the Slaugh Aos’An and the love of the Battanian people for more than a generation may be vaunted into the ranks of the Na Sidhfir - the Immortal Men of the Woods. Occupying a position equally heroic and tragic, the grand figures of the Na Sidhfir are claimed to be tireless and exhausted entities - unable to rest so long as they are remembered, but too self-absorbed to allow their songs to go unsung. Derwyddon practitioners claim the Na Sidhfir possess the bodies of Wolfskins, allowing them to rest and ravage away from the heavenly realms."),
                new TextObject(),
                new TextObject("{=!}Ancestor Spirits"));

            amraSecondary2 = new Divinity(new TextObject("{=!}Dymhna Sidset"),
                new TextObject("{=!}Patient devils, the Dymhna Sidset are the stuff of children’s parables and ill told tales around campfires. They are the spittal on a rabid dog’s lips, the rage of a mother bear seeking a misplaced cub, the cold biting steel that strikes only in betrayal. Though the attempted Calradification of the Uchalion Plateau could not purge this pagan belief set entirely, it did compartmentalize and mangle its body of rituals. Giants, ghosts, and many an unseen shade were changed from beings of tale and legend to “patient devils” by the whims of the Empire. In recent years, some have sought to venerate the Dymhna Sidset; viewing them instead as aspects of rebellion and irredentism."),
                new TextObject(),
                new TextObject("{=!}Natural Spirits"));


            darusosianMain = new Divinity(new TextObject("{=!}Martyr Darusos"),
                new TextObject("{=!}Born in a period of relative internal peace and outward expansion, Darusos was a young emperor who allegedly sought reformations within the Calradic Empire before being betrayed by his closest generals and crucified upon a sacred fig tree in the imperial gardens of Lycaron. Those devoted to Darusos view him as having achieved the rite of the divus in his dying hours, achieving immortality and awaiting those who seek to practice his reforms in the heavenly realms."),
                new TextObject());

            darusosianSecondary1 = new Divinity(new TextObject("{=!}Imperial Cult"),
                new TextObject("{=!}Though there has long been an imperial cult in the Calradic Empire, it grew in popularity in the generations after Darusos’s murder. Emperors were deified, made to stand alongside their own gods as peers. During the waning generations of the united empire many would proclaim themselves god-emperor, or other divinely appointed titles; the rite of the divus can only transubstantiate an emperor upon their death. Thus the last truly ordained imperial cult is that which preaches the words of Arenicos Divus; though upstart branches have begun for an inevitable worship of Ira Divus."),
                new TextObject(),
                new TextObject("{=!}Cult"));

            darusosianSecondary2 = new Divinity(new TextObject("{=!}Lycaronian Triad"),
                new TextObject("{=!}The Empire has long held its own pantheon of divine entities which rule over all aspects of mortal life and which are appeased by means of ritual sacrifice, festival activities, and prayers for absolution. Within the Darusosian Martyrdom, the locally vaunted Lycaronian Triad is held above all other eternal divinities and viewed as adjacent to mortal emperors risen to divinity by the rites of the divus. Iovis, the Sky-Father reigns as the henotheistic patriarch who traditionally dwells upon Mount Erithrys. He is accompanied by Astaronia, his bride who represents that which must be protected by the machinations of imperial might; and by his daughter Mesnona who was born from the ego of Iovis and who grants insight to mortal petitioners."),
                new TextObject(),
                new TextObject("{=!}Gods"));
        }

        public Divinity AseraMain => aseraMain;
        public Divinity AseraSecondary1 => aseraSecondary1;
        public Divinity AseraSecondary2 => aseraSecondary2;
        public Divinity AseraSecondary3 => aseraSecondary3;
        public Divinity AmraMain => amraMain;
        public Divinity AmraSecondary1 => amraSecondary1;
        public Divinity AmraSecondary2 => amraSecondary2;

        public Divinity DarusosianMain => darusosianMain;
        public Divinity DarusosianSecondary1 => darusosianSecondary1;
        public Divinity DarusosianSecondary2 => darusosianSecondary2;
    }
}