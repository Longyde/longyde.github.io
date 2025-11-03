"use strict";

// Call directly (DOM is ready because of `defer`)
consoleText(
  [
    'Welcome!'.
    'My name is Devonte Longmire',
    "Building since 1999 — now with purpose.",
    "Raspberry Pi tinkerer. AI collaborator.",
    "Software engineer and creative problem solver.",
    "Turning code into tools that empower people.",
    "Analytical mind. Autonomous maker. Lifelong learner."
  ],
  "text",
  ["#47C6FF", "#8FD3FF", "#FFFFFF"]
);

function consoleText(words, id, colors) {
  if (!Array.isArray(words) || words.length === 0) return;

  const target = document.getElementById(id);
  const con = document.getElementById("console");
  if (!target || !con) return;

  const palette = (colors && colors.length ? colors : ["#000"]).map(c =>
    c.startsWith("#") ? c : `#${c}`
  );

  let wordIdx = 0;
  let letterCount = 1;
  let direction = 1; // 1 = typing, -1 = deleting
  let waiting = false;

  target.style.color = palette[0];

  const typeInterval = setInterval(() => {
    const current = words[wordIdx];

    if (!waiting) {
      target.textContent = current.substring(0, letterCount);
      letterCount += direction;
    }

    if (letterCount === current.length + 1 && !waiting) {
      waiting = true;
      setTimeout(() => {
        direction = -1;
        waiting = false;
      }, 1000);
    }

    if (letterCount === 0 && !waiting) {
      waiting = true;
      setTimeout(() => {
        direction = 1;
        wordIdx = (wordIdx + 1) % words.length;
        const colorIdx = wordIdx % palette.length;
        target.style.color = palette[colorIdx];
        letterCount = 1;
        waiting = false;
      }, 1000);
    }
  }, 120);

  setInterval(() => {
    con.classList.toggle("hidden");
  }, 400);
}
