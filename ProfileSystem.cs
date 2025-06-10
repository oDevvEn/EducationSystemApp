using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EducationSystemApp {
    internal class ProfileSystem { // for jsonserliazer to work, i have to use {get;set;} for some reason...
        public int mathScore { get; set; }
        public int memoryScore { get; set; }
        public int wordScore { get; set; }
        public int speedScore { get; set; }


        public ProfileSystem(int mathScore, int memoryScore, int wordScore, int speedScore) {
            this.mathScore = mathScore;
            this.memoryScore = memoryScore;
            this.wordScore = wordScore;
            this.speedScore = speedScore;
        }



        public static Dictionary<string, ProfileSystem> profiles = new Dictionary<string, ProfileSystem>(); // name,scores
        public static ProfileSystem? profile;


        public static void SaveProfiles() {
            string rawProfiles = JsonSerializer.Serialize(profiles, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText("profiles.json", rawProfiles);
        }


        public static void LoadProfiles() {
            if (File.Exists("profiles.json")) {
                string rawProfiles = File.ReadAllText("profiles.json");
                profiles = JsonSerializer.Deserialize<Dictionary<string, ProfileSystem>>(rawProfiles)!;
            }
        }


        public static void CreateProfile(string name) {
            profiles[name] = new ProfileSystem(0, 0, 0, int.MaxValue);
            SaveProfiles();
        }


        public static void SelectProfile(string name) {
            if (!profiles.TryGetValue(name, out profile)) {
                throw new NullReferenceException($"Profile with name {name} not found..?");
            }
        }
    }
}
