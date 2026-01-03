<a id="readme-top"></a>

[![Contributors][contributors-shield]][contributors-url]
[![Forks][forks-shield]][forks-url]
[![Stargazers][stars-shield]][stars-url]
[![Issues][issues-shield]][issues-url]
[![Unlicense License][license-shield]][license-url]
[![LinkedIn][linkedin-shield]][linkedin-url]

<div>
   <h1>Cubethon (Unity Beginner Project)</h1>
   <p align="center"> 
    <img src="Assets/cubethon.png" alt="cubethon" width="800"/><br>
    A Unity learning project built by following Brackeys’ Unity Beginner Tutorial playlist, using YouTube video transcripts as a structured guide to practice core Unity and C# game development fundamentals.
   </p><br>
    <a href="#about-the-project"><strong>Explore the docs »</strong></a>
  </p>
</div>
<details>
   <summary>Table of Contents</summary>
   <ol>
      <li><a href="#about-the-project">About The Project</a></li>
      <li><a href="#built-with">Built With</a></li>
      <li><a href="#file-structure">File Structure</a></li>
      <li><a href="#getting-started">Getting Started</a></li>
      <li><a href="#usage">Usage & Testing</a></li>
      <li><a href="#roadmap">Roadmap</a></li>
      <li><a href="#challenges">Challenges</a></li>
   </ol>
</details>
<h2 id="about-the-project">About The Project</h2>
<p>
    This repository documents my first steps into <strong>Unity game development</strong>, built while learning from <strong>Brackeys’ Unity Beginner Tutorial playlist</strong>.
</p>
<p>Instead of blindly copying code, I:</p>
<ul>
    <li>Studied YouTube video transcripts</li>
    <li>Implemented features step by step</li>
    <li>Experimented with values, scripts, and components</li>
    <li>Learned how Unity scenes, scripts, and physics work together</li>
</ul>
<p>The focus of this project is learning by building, not creating a polished commercial game.</p>
<p>
    🎥 Tutorial Source:<br>
    <a href="https://www.youtube.com/playlist?list=PLPV2KyIb3jR5QFsefuO2RlAgWEz6EvVi6"><strong>Brackeys – Unity Beginner Tutorial Playlist</strong></a>
</p>
<div align="right"><a href="#readme-top">↑ Back to Top</a></div>

<h2 id="built-with">Built With</h2>
<ul>
   <li><strong>Unity (3D):</strong> Used as the game engine to design levels, manage scenes, handle physics, and control game objects.</li>
   <li><strong>C#:</strong> Used for scripting player movement, obstacle interactions, level progression, and game logic.</li>
   <li><strong>Unity Physics Engine:</strong> Rigidbody and Colliders handle movement, collision detection, and obstacle interactions.</li>
   <li><strong>Unity Input System (Keyboard):</strong> Captures player input (<code>A</code> / <code>D</code> keys) to move the cube left and right.</li>
</ul>
<div align="right"><a href="#readme-top">↑ Back to Top</a></div>

<h2 id="file-structure">File Structure</h2>
<pre>cubethon/
├── .git/                    # Git version control metadata
├── .vs/                     # Visual Studio configuration files
├── Assets/                  # Core game assets
│   ├── Scenes/              # Unity scenes
│   ├── Scripts/             # C# gameplay scripts
│   ├── Materials/           # Materials and shaders
│   └── Prefabs/             # Reusable game objects
├── Builds/                  # Local build outputs
├── Library/                 # Unity cache (not recommended for Git)
├── Logs/                    # Editor logs
├── Packages/                # Unity package dependencies
├── ProjectSettings/         # Unity project configuration
├── UserSettings/            # Local user settings
├── Assembly-CSharp.csproj
├── Assembly-CSharp-Editor.csproj
├── How to Make A Video Game.sln
└── README.md                # Project documentation
</pre>
<div align="right"><a href="#readme-top">↑ Back to Top</a></div>

<h2 id="getting-started">Getting Started</h2>
<h3>Prerequisites</h3>
<ul>
   <li><strong>Unity Hub</strong></li>
   <li>Unity Editor (recommended LTS version)</li>
   <li>Visual Studio</li>
</ul>
<h3>Installation & Deployment</h3>
<ol>
   <li>Clone the repository.</li>
   <li>Open <strong>Unity Hub</strong></li>
   <li>Click <strong>Open Project</strong></li>
   <li>Select the cloned project folder</li>
   <li>Open the main scene and press ▶ Play</li>
</ol>
<div align="right"><a href="#readme-top">↑ Back to Top</a></div>

<h2 id="usage">Usage & Testing</h2>

<h3>🎮 Gameplay Overview</h3>
<p>This is a simple forward-running obstacle game.</p>
<ul>
    <li>A cube that moves forward automatically at high speed</li>
    <li>The objective is to reach the finish line without hitting obstacles</li>
    <li>The race path is straight, with obstacles placed along the way</li>
    <li>
        Players must dodge obstacles by pressing: 
        <ul>
            <li>A → move left</li>
            <li>D → move right</li>
        </ul>
    </li>
    <li>The game includes 3 progressively challenging levels</li>
</ul>
<p>The project focuses on basic player control, obstacle avoidance, and level progression, making it ideal for learning Unity fundamentals.</p>
<p>Watch the sample gameplay at my linkedIn post here: <a href="https://www.linkedin.com/posts/activity-7413256773786210304-Npkj?utm_source=share&utm_medium=member_desktop&rcm=ACoAAC64xbIBQ-4tMrEhn1BXRr8SmkzqiMPX0k8">Cubethon</a></p>

<h3>Test Details</h3>
<ul>
    <li>Use keyboard input to control the player</li>
    <li>
        Observe how:
        <ul>
            <li>Scripts interact with GameObjects</li>
            <li>Physics components affect movement</li>
            <li>Scene hierarchy influences gameplay behavior</li>
        </ul>
    </li>
</ul>
<p>Testing focused on:</p>
<ul>
    <li>Script execution order</li>
    <li>Player movement responsiveness</li>
    <li>Collision detection</li>
    <li>Scene transitions</li>
</ul>
<p>This project is mainly tested manually through <strong>Play Mode</strong> experimentation.</p>
<div align="right"><a href="#readme-top">↑ Back to Top</a></div>

<h2 id="roadmap">Project Roadmap</h2>
<ul>
   <li>[x] Complete Brackeys beginner tutorial core lessons</li>
   <li>[x] Understand Unity editor layout & workflow</li>
   <li>[x] Write and attach basic C# scripts</li>
   <li>[x] Add simple UI elements</li>
   <li>[ ] Refactor scripts for better structure</li>
   <li>[ ] Expand with custom mechanics beyond tutorial scope</li>
</ul>
<div align="right"><a href="#readme-top">↑ Back to Top</a></div>

<h2 id="challenges-faced">Challenges</h2>
<table>
   <thead>
      <tr>
         <th>Challenge</th>
         <th>Solution</th>
      </tr>
   </thead>
   <tbody>
      <tr>
         <td><strong>Understanding Unity’s component-based architecture</strong></td>
         <td>Learned by breaking scripts into small responsibilities and testing changes incrementally</td>
      </tr>
      <tr>
         <td><strong>Script execution confusion</strong></td>
         <td>Used <code>Debug.Log</code> and Inspector observations to trace runtime behavior</td>
      </tr>
      <tr>
         <td><strong>Physics behaving unexpectedly</strong></td>
         <td>Tuned Rigidbody values and collision settings through experimentation</td>
      </tr>
      <tr>
         <td><strong>Scene & object management</strong></td>
         <td>Organized hierarchy and prefabs to reduce clutter</td>
      </tr>
   </tbody>
</table>
<div align="right"><a href="#readme-top">↑ Back to Top</a></div>

<h2 id="contact">🙏 Acknowledgements</h2>
<p>Special thanks to <strong>Brackeys</strong> for the legendary Unity tutorials that continue to help beginners enter game development.</p>
<p>This repository is intended for learning and portfolio showcase purposes only.</p>
<div align="right"><a href="#readme-top">↑ Back to Top</a></div>

[contributors-shield]: https://img.shields.io/github/contributors/ShenLoong99/Cubethon.svg?style=for-the-badge
[contributors-url]: https://github.com/ShenLoong99/Cubethon/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/ShenLoong99/Cubethon.svg?style=for-the-badge
[forks-url]: https://github.com/ShenLoong99/Cubethon/network/members
[stars-shield]: https://img.shields.io/github/stars/ShenLoong99/Cubethon.svg?style=for-the-badge
[stars-url]: https://github.com/ShenLoong99/Cubethon/stargazers
[issues-shield]: https://img.shields.io/github/issues/ShenLoong99/Cubethon.svg?style=for-the-badge
[issues-url]: https://github.com/ShenLoong99/Cubethon/issues
[license-shield]: https://img.shields.io/github/license/ShenLoong99/Cubethon.svg?style=for-the-badge
[license-url]: https://github.com/ShenLoong99/Cubethon/blob/master/LICENSE.txt
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=for-the-badge&logo=linkedin&colorB=555
[linkedin-url]: https://linkedin.com/in/si-kai-tan
