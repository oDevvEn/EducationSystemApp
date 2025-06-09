using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EducationSystemApp {
    internal class tempProfile { // for jsonserliazer to work, i have to use {get;set;} for some reason...
        public int mathScore { get; set; }
        public int memoryScore { get; set; }
        public int wordScore { get; set; }
        public int speedScore { get; set; }


        public tempProfile(int mathScore, int memoryScore, int wordScore, int speedScore) {
            this.mathScore = mathScore;
            this.memoryScore = memoryScore;
            this.wordScore = wordScore;
            this.speedScore = speedScore;
        }


        public static Dictionary<string, tempProfile> profiles; // name,scores
        public static tempProfile? profile;
        public static void SaveProfiles() {
            string rawProfiles = JsonSerializer.Serialize(profiles, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText("profiles.json", rawProfiles);
        }


        public static void LoadProfiles() {
            if (File.Exists("profiles.json")) {
                string rawProfiles = File.ReadAllText("profiles.json");
                profiles = JsonSerializer.Deserialize<Dictionary<string, tempProfile>>(rawProfiles)!;
            }
            else {
                InitProfiles();
            }
            profile = profiles.GetValueOrDefault("a")!;
            Debug.WriteLine(profile.speedScore);
        }


        public static void InitProfiles() {
            profiles = new Dictionary<string, tempProfile>() {
                { "a", new tempProfile(1, 2, 3, 2000) },
                { "b", new tempProfile(3, 2, 1, 1000) },
                { "c", new tempProfile(30000, 0, 30, 400) },
                { "d", new tempProfile(5, 6, 7, 600) },
            };
            profile = profiles.GetValueOrDefault("a")!;
            Debug.WriteLine(profile.speedScore);
        }
    }
}
