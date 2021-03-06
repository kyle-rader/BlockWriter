using FluentAssertions;
using NUnit.Framework;

namespace BlockWriterTest
{
    public class WriterTest
    {
        BlockWriter.Writer subject = null;
        InMemoryConsole console = null;

        [SetUp]
        public void Setup()
        {
            console = new InMemoryConsole();
            subject = new BlockWriter.Writer(console);
        }

        [Test]
        public void Lower()
        {
            subject.Write("a b c d e f g h i j k l m n o p q r s t u v w x y z");
            console.Output().Should().Be(
@"         _                  _           __           _       _     _   _      _                                                            _                                                   
  __ _  | |__     ___    __| |   ___   / _|   __ _  | |__   (_)   (_) | | __ | |  _ __ ___    _ __     ___    _ __     __ _   _ __   ___  | |_   _   _  __   __ __      __ __  __  _   _   ____
 / _` | | '_ \   / __|  / _` |  / _ \ | |_   / _` | | '_ \  | |   | | | |/ / | | | '_ ` _ \  | '_ \   / _ \  | '_ \   / _` | | '__| / __| | __| | | | | \ \ / / \ \ /\ / / \ \/ / | | | | |_  /
| (_| | | |_) | | (__  | (_| | |  __/ |  _| | (_| | | | | | | |   | | |   <  | | | | | | | | | | | | | (_) | | |_) | | (_| | | |    \__ \ | |_  | |_| |  \ V /   \ V  V /   >  <  | |_| |  / / 
 \__,_| |_.__/   \___|  \__,_|  \___| |_|    \__, | |_| |_| |_|  _/ | |_|\_\ |_| |_| |_| |_| |_| |_|  \___/  | .__/   \__, | |_|    |___/  \__|  \__,_|   \_/     \_/\_/   /_/\_\  \__, | /___|
                                             |___/              |__/                                         |_|         |_|                                                       |___/       
");
        }

        [Test]
        public void Upper()
        {
            subject.Write("A B C D E F G H I J K L M N O P Q R S T U V W X Y Z");
            console.Output().Should().Be(
@"    _      ____     ____   ____    _____   _____    ____   _   _   ___       _   _  __  _       __  __   _   _    ___    ____     ___    ____    ____    _____   _   _  __     __ __        __ __  __ __   __  _____
   / \    | __ )   / ___| |  _ \  | ____| |  ___|  / ___| | | | | |_ _|     | | | |/ / | |     |  \/  | | \ | |  / _ \  |  _ \   / _ \  |  _ \  / ___|  |_   _| | | | | \ \   / / \ \      / / \ \/ / \ \ / / |__  /
  / _ \   |  _ \  | |     | | | | |  _|   | |_    | |  _  | |_| |  | |   _  | | | ' /  | |     | |\/| | |  \| | | | | | | |_) | | | | | | |_) | \___ \    | |   | | | |  \ \ / /   \ \ /\ / /   \  /   \ V /    / / 
 / ___ \  | |_) | | |___  | |_| | | |___  |  _|   | |_| | |  _  |  | |  | |_| | | . \  | |___  | |  | | | |\  | | |_| | |  __/  | |_| | |  _ <   ___) |   | |   | |_| |   \ V /     \ V  V /    /  \    | |    / /_ 
/_/   \_\ |____/   \____| |____/  |_____| |_|      \____| |_| |_| |___|  \___/  |_|\_\ |_____| |_|  |_| |_| \_|  \___/  |_|      \__\_\ |_| \_\ |____/    |_|    \___/     \_/       \_/\_/    /_/\_\   |_|   /____|
                                                                                                                                                                                                                    
");
        }
    }
}